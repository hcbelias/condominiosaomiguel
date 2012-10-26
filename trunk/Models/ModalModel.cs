using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;

namespace CondominioSaoMiguel.Models
{

    public class ModalModel : BaseModel
    {
        String mHeader;

        public String Header
        {
            get { return mHeader; }
            set { mHeader = value; }
        }

        String mBody;

        public String Body
        {
            get { return mBody; }
            set { mBody = value; }
        }

        String mFooter;

        public String Footer
        {
            get { return mFooter; }
            set { mFooter = value; }
        }

        Boolean mBackdrop;

        public Boolean Backdrop
        {
            get { return mBackdrop; }
            set { mBackdrop = value; }
        }

        Boolean mKeyboard;

        public Boolean Keyboard
        {
            get { return mKeyboard; }
            set { mKeyboard = value; }
        }

        Boolean mShow;

        public Boolean Show
        {
            get { return mShow; }
            set { mShow = value; }
        }

        public ModalModel(String pId, String pHeader, String pBody, String pFooter, Boolean pBackdrop, Boolean pKeyboard, Boolean pShow)
        {
            this.Id = pId;
            this.Header = pHeader;
            this.Body = pBody;
            this.Footer = pFooter;
            this.Backdrop = pBackdrop;
            this.Keyboard = pKeyboard;
            this.Show = pShow;
        }
             
    }

}
