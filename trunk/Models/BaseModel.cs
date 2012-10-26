using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;

namespace CondominioSaoMiguel.Models
{

    public class BaseModel
    {
        private String mId;

        public String Id
        {
            get { return mId; }
            set { mId = value; }
        }

        public BaseModel()
        {
            this.Id = null;
        }
      

        public BaseModel(string pId)
        {
            this.Id = pId;
        }
             
    }

}
