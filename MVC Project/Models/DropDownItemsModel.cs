using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Project.Models
{
    /* Model for the Combobox items. We could potentially add more 
       majors on the fly this way, but we only need two for now.*/
    public class DropDownItemsModel
    {
        public string Text { get; set; }
        public string Value { get; set; }

        //Constructor
        public DropDownItemsModel(string v, string t)
        {
            Value = v;
            Text = t;
        }
    }
}