using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;

namespace CondominioSaoMiguel.Models
{

    public class CarouselModel : BaseModel
    {
        private int mInterval;

        public int? Interval
        {
            get { return mInterval; }
            set { mInterval = value.HasValue ? value.Value : 0; }
        }

        private List<String> mItemList = new List<String>();

        public List<String> ItemList
        {
            get { return mItemList; }
            set { mItemList = value; }
        }

        public CarouselModel(string pId, int pInterval, List<String> pItemList)
        {
            this.Id = pId;
            this.Interval = pInterval;
            this.ItemList = pItemList;
        }
             
    }

}
