using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Project.Models
{
    public class DropDownItemsModel
    {
        public string Text { get; set; }
        public string Value { get; set; }

        public DropDownItemsModel(string v, string t)
        {
            Value = v;
            Text = t;
        }
    }
}