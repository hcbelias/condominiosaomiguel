using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataController
{
    public class Controllers
    {
        public static MasterDataController GetMasterData(String userAuthenticated)
        {
            return MasterDataController.Get(userAuthenticated);
        }

        public static MasterDataController GetMasterData()
        {
            return MasterDataController.Get(null);
        }

    }
}
