using MVC_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Project.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            /* Populate drop down model */
            List<DropDownItemsModel> listItems = new List<DropDownItemsModel>();
            listItems.Add(new DropDownItemsModel("BSIS", "BSIS - Undergraduate Degree"));
            listItems.Add(new DropDownItemsModel("MISM", "MISM - Masters Degree"));
            /* Add Items to ViewBag as a SelectList type*/
            ViewBag.PageID = new SelectList(listItems, "Value", "Text");

            return View();
        }

        /* Page forwarding from combobox */
        public ActionResult ComboResult(String PageID)
        {
            //Returns the view assocated with the Page Selected
            return View(PageID);
        }

        /* Return the views for the associated pages */
        public ActionResult BSIS()
        {
            return View();
        }

        public ActionResult MISM()
        {
            return View();
        }

        public ActionResult Faculty()
        {
            return View();
        }
        public ActionResult Advisory()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}