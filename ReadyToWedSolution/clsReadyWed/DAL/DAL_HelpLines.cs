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
    public abstract class HelpLines_DAO
    {
        private int _HelpLineId;
        private string _HelpLineMessage;

        #region  Constructors

        public HelpLines_DAO()
        {
            _HelpLineId = 0;
        }

        public HelpLines_DAO(int HelpLineId)
        {
            _HelpLineId = HelpLineId;
        }

        public HelpLines_DAO(int HelpLineId, string HelpLineMessage)
        {
            _HelpLineId = HelpLineId;
            _HelpLineMessage = HelpLineMessage;
           
        }

        #endregion

        #region properties

        public int HelpLineId
        {
            get
            {
                return _HelpLineId;
            }


            set
            {
                _HelpLineId = value;
            }

        }

        public string HelpLineMessage
        {
            get
            {
                return _HelpLineMessage;
            }


            set
            {
                _HelpLineMessage = value;
            }

        }

        #endregion

        protected DataSet DAOGetHelpLineMessageById(int Id)
        {

            Database db = DatabaseFactory.CreateDatabase("ApplicationDataServices");
            string sqlCommand = "usp_GetHelpLineMessageById";
            DbCommand dbCommandWrapper = db.GetStoredProcCommand(sqlCommand);
            db.AddInParameter(dbCommandWrapper, "@paramHelpLineId", DbType.Int32, Id);
            return db.ExecuteDataSet(dbCommandWrapper);

        }
    }
}
