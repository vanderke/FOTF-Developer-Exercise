using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsReadyWed.BLL
{
    public class Customers : DAL.Customers_DAO
    {
        #region Constructors

        public Customers()
        {
        }

        public Customers(int CustomerId)
            : base(CustomerId)
        {
        }


        public Customers(int CustomerId, string FirstName, string MiddleName, string LastName, string Address1, string Address2, string City, int StateId, string Zip4, string Zip5, string AreaCode, string PhoneNumber)
            : base(CustomerId, FirstName, MiddleName, LastName, Address1, Address2, City, StateId, Zip4, Zip5, AreaCode, PhoneNumber)
        {
        }

        #endregion

        protected void AddCustomer(string FirstName, string MiddleName, string LastName, string Address1, string Address2, string City, int StateId, string Zip4, string Zip5, string AreaCode, string PhoneNumber)
        {
            if (FirstName == "") { FirstName = null; }
            if (MiddleName == "") { MiddleName = null; }
            if (LastName == "") { LastName = null; }
            if (Address1 == "") { Address1 = null; }
            if (Address2 == "") { Address2 = null; }
            if (City == "") { City = null; }
            if (Zip4 == "") { Zip4 = null; }
            if (Zip5 == "") { Zip5 = null; }
            if (AreaCode == "") { AreaCode = null; }
            if (PhoneNumber == "") { PhoneNumber = null; }

            base.DAOAddCustomer(FirstName, MiddleName, LastName, Address1, Address2, City, StateId, Zip4, Zip5, AreaCode, PhoneNumber);
        }
    }
}
