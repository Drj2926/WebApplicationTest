using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestEnvironment.Models;
using TestEnvironment.DataAccessLayer;

namespace TestEnvironment.Controllers
{
    public class AccountIDMaintController : Controller
    {
        private AccountIDMaintDAL dal = new AccountIDMaintDAL();

        // GET: AccountIDMaint
        public ActionResult Index()
        {
             List<AccountIDMaintSummary> summary  = dal.getAccountSummary();
            return View(summary);
        }
       [HttpPost]
        public ActionResult Index(string searchText)
        {
            List<AccountIDMaintSummary> summary = dal.getAccountSummary();
            if(searchText.IsNullOrEmpty())
            {
                return View();
            }
            else
                var filtered = 
            return View();
        }

        // GET: AccountIDMaint/Details/5
        public ActionResult Details(string id)
        {
            //CREATE YOUR VIEW MODEL IN HERE
            AccountIDMaintViewModel details = new AccountIDMaintViewModel();
            List<CustomersAccountID> accountIDs = new List<CustomersAccountID>();
              
            details.details = dal.getAccountIDDetails(id);
            details.customerIDs = dal.getAccountIDs(id);
            return View(details);
        }

        // GET: AccountIDMaint/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AccountIDMaint/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AccountIDMaint/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AccountIDMaint/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AccountIDMaint/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AccountIDMaint/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
