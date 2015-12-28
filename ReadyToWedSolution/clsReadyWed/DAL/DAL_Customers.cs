using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace clsReadyWed.DAL
{
    public abstract class Customers_DAO
    {
        private int _CustomerId;
        private string _FirstName;
        private string _MiddleName;
        private string _LastName;
        private string _Address1;
        private string _Address2;
        private string _City;
        private int _StateId;
        private string _Zip4;
        private string _Zip5;
        private string _AreaCode;
        private string _PhoneNumber;

        #region  Constructors

        public Customers_DAO()
        {
            _CustomerId = 0;
        }

        public Customers_DAO(int CustomerId)
        {
            _CustomerId = CustomerId;
        }

        public Customers_DAO(int CustomerId, string FirstName, string MiddleName, string LastName, string Address1, string Address2, string City, int StateId, string Zip4, string Zip5, string AreaCode, string PhoneNumber)
        {
            _CustomerId = CustomerId;
            _FirstName = FirstName;
            _MiddleName = MiddleName;
            _LastName = LastName;
            _Address1 = Address1;
            _Address2 = Address2;
            _City = City;
            _StateId = StateId;
            _Zip4 = Zip4;
            _Zip5 = Zip5;
            _AreaCode = AreaCode;
            _PhoneNumber = PhoneNumber;
        }

        #endregion

        #region properties

        public int CustomerId
        {
            get
            {
                return _CustomerId;
            }


            set
            {
                _CustomerId = value;
            }

        }

        public string FirstName
        {
            get
            {
                return _FirstName;
            }


            set
            {
                _FirstName = value;
            }

        }

        public string MiddleName
        {
            get
            {
                return _MiddleName;
            }


            set
            {
                _MiddleName = value;
            }

        }

        public string LastName
        {
            get
            {
                return _LastName;
            }


            set
            {
                _LastName = value;
            }

        }

        public string Address1
        {
            get
            {
                return _Address1;
            }


            set
            {
                _Address1 = value;
            }

        }

        public string Address2
        {
            get
            {
                return _Address2;
            }


            set
            {
                _Address2 = value;
            }

        }

        public string City
        {
            get
            {
                return _City;
            }


            set
            {
                _City = value;
            }

        }

        public int StateId
        {
            get
            {
                return _StateId;
            }


            set
            {
                _StateId = value;
            }

        }

        public string Zip4
        {
            get
            {
                return _Zip4;
            }


            set
            {
                _Zip4 = value;
            }

        }

        public string Zip5
        {
            get
            {
                return _Zip5;
            }


            set
            {
                _Zip5 = value;
            }

        }

        public string AreaCode
        {
            get
            {
                return _AreaCode;
            }


            set
            {
                _AreaCode = value;
            }

        }

        public string PhoneNumber
        {
            get
            {
                return _PhoneNumber;
            }


            set
            {
                _PhoneNumber = value;
            }

        }

        #endregion

        protected void DAOAddCustomer(string FirstName, string MiddleName, string LastName, string Address1, string Address2, string City, int StateId, string Zip4, string Zip5, string AreaCode, string PhoneNumber)
        {

            Database db = DatabaseFactory.CreateDatabase("ApplicationDataServices");
            string sqlCommand = "usp_AddCustomer";
            DbCommand dbCommandWrapper = db.GetStoredProcCommand(sqlCommand);
            db.AddInParameter(dbCommandWrapper, "@paraFirstName", DbType.String, FirstName);
            db.AddInParameter(dbCommandWrapper, "@paraMiddleName", DbType.String, MiddleName);
            db.AddInParameter(dbCommandWrapper, "@paraLastName", DbType.String, LastName);
            db.AddInParameter(dbCommandWrapper, "@paraAddress1", DbType.String, Address1);
            db.AddInParameter(dbCommandWrapper, "@paraAddress2", DbType.String, Address2);
            db.AddInParameter(dbCommandWrapper, "@paraCity", DbType.String, City);
            db.AddInParameter(dbCommandWrapper, "@paraStateId", DbType.Int32, StateId);
            db.AddInParameter(dbCommandWrapper, "@paraZip4", DbType.String, Zip4);
            db.AddInParameter(dbCommandWrapper, "@paraZip5", DbType.String, Zip5);
            db.AddInParameter(dbCommandWrapper, "@paraAreaCode", DbType.String, AreaCode);
            db.AddInParameter(dbCommandWrapper, "@paraPhoneNumber", DbType.String, PhoneNumber);
            db.ExecuteDataSet(dbCommandWrapper);

        }


    }
}
