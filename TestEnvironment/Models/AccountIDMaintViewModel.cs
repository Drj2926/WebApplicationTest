using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestEnvironment.Models
{
    public class AccountIDMaintSummary
    {
        public string accountID { get; set; }
        public string nickName { get; set; }
        public string business { get; set; }
        public string customerType { get; set; }
    }

    public class AccountIDMaintViewModel
    {
        public WhitegloveDetails_Test details { get; set; }
        public List<CustomersAccountID> customerIDs; 
    }

    public class CustomersAccountID
    {
       public string accountID;
       public string customerID;
       public string business;
    }

    public class CustomerAccountTypes
    {
        public string accountID { get; set; }
        public int accountType { get; set; }
    }
    public class AccountTypes
    {
        int type { get; set; }
        string title { get; set; }
    }
  
}