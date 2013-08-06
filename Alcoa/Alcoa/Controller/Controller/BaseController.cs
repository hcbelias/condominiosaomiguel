using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Remoting.Proxies;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting;
using System.Collections;
using System.Reflection;
using Util;
using DAL;


namespace DataController
{
    public class BaseController : MarshalByRefObject
    {
        private String authenticatedUser;

        public String AuthenticatedUser
        {
            get { return authenticatedUser; }
            set { authenticatedUser = value; }
        }

        internal protected static T CreateProxy<T>(T controller) where T : BaseController
        {
            return (T)new ControllerProxy(controller).GetTransparentProxy();
        }

        private class ControllerProxy : RealProxy
        {
            BaseController controller;

            public ControllerProxy(BaseController controller)
                : base(controller.GetType())
            {
                this.controller = controller;
            }

            public override IMessage Invoke(IMessage message)
            {
                try
                {
                    DataContext.CreateContext(this.controller.AuthenticatedUser);
                    IMethodReturnMessage messageReturn = RemotingServices.ExecuteMessage(controller, (IMethodCallMessage)message);
                    DataContext.CommitContext();
                    return messageReturn;
                }
                finally
                {
                    DataContext.ReleaseContext();
                }
            }


        }

    }
}
