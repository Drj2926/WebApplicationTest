using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using TestEnvironment.Models;

namespace TestEnvironment.DataAccessLayer
{
    public class AccountIDMaintDAL
    {
        private TestDevEntities db = new TestDevEntities();

        public List<AccountIDMaintSummary> getAccountSummary()
        {
            var summary = from s in db.sp_GetAccountIDSummary()
                          select new AccountIDMaintSummary {
                             accountID = s.CustomerID
                             ,nickName = s.ContactName
                             ,business = s.CompanyName
                             ,customerType = s.Title
                          };
            //return list
            return summary.ToList();
        }

        public WhitegloveDetails_Test getAccountIDDetails(string accountID)
        {
            var details = from d in db.WhitegloveDetails_Test
                        where d.CustomerID.Equals(accountID) 
                        select d;
            return details.FirstOrDefault();            
        }

        public List<CustomersAccountID> getAccountIDs(string accountID)
        {
            var accountIDs = from a in db.sp_getCustomerIDInfo(accountID)
                             select new CustomersAccountID
                             {
                                 accountID = a.AccountID
                                 ,customerID = a.CustomerID
                                 ,business = a.ContactTitle
                             };
            return accountIDs.ToList();
        }
        /*
        public List<AccountIDMaintSummary> getSearchResults(string searchText)
        {
            var summary = from s in db.sp_AutoComplete_Get_Customer(searchText)
                          select new AccountIDMaintSummary
                          {
                              accountID = s.CustomerID
                              ,
                              nickName = s.ContactName
                              ,
                              business = s.CompanyName
                              ,
                              customerType = s.Title
                          };
            return summary.ToList();
        }
         * */
    }
}