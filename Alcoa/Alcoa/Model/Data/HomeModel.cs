﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;

namespace Model
{

    public class HomeModel
    {
        public string Message { get; set; }

        public string ClassCSS { get; set; }
    }
}