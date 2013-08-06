using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using BLL;
using DAL;
using Model;
using System.Collections;

namespace DataController
{
    public partial class MasterDataController : BaseController
    {
        private MasterDataController(string userAuthenticated)
        {
            this.AuthenticatedUser = userAuthenticated;
        }

        public static MasterDataController Get(string userAuthenticated)
        {
            return CreateProxy(new MasterDataController(userAuthenticated));
        }

        public Model.LoginModel GetLogin(string p_Email, string p_Password)
        {
            return BLL.LoginBLL.GetLogin(p_Email, p_Password);
        }

        public LoginModel GetLoginPeloEmail(string p_Email)
        {
            return BLL.LoginBLL.GetLoginPeloEmail(p_Email);
        }

        public Model.ChartModel GenerateChart(Model.IndexChartModel p_Model)
        {
            return ChartBLL.GenerateChart(p_Model);
        }
    }
}
