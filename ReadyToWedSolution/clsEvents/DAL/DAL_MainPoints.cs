using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace OLSReadyToWed
{
    public abstract class MainPoints_DAO
    {
        private int _MainPointId;
        private string _MainPoint;
        private string _MainPointDescription;

        #region  Constructors

        public MainPoints_DAO()
        {
            _MainPointId = 0;
        }

        public MainPoints_DAO(int MainPointId)
        {
            _MainPointId = MainPointId;
        }

        public MainPoints_DAO(int MainPointId, string MainPoint, string MainPointDescription)
        {
            _MainPointId = MainPointId;
            _MainPoint = MainPoint;
            _MainPointDescription = MainPointDescription;
        }

        #endregion

        #region properties

        public int MainPointId
        {
            get
            {
                return _MainPointId;
            }


            set
            {
                _MainPointId = value;
            }

        }

        public string MainPoint
        {
            get
            {
                return _MainPoint;
            }


            set
            {
                _MainPoint = value;
            }

        }

        public string MainPointDescription
        {
            get
            {
                return _MainPointDescription;
            }


            set
            {
                _MainPointDescription = value;
            }

        }

        #endregion

        protected DataSet DAOGetAllMainPoints()
        {
            Database db = DatabaseFactory.CreateDatabase("5CG51343PL");
            string sqlCommand = "usp_GetAllMainPoints";
            DbCommand dbCommandWrapper = db.GetStoredProcCommand(sqlCommand);
            return db.ExecuteDataSet(dbCommandWrapper);
        }

    }
}
