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
    public abstract class T_CD_States_DAO
    {
        private int _StateId;
        private string _StateName;

        #region  Constructors

        public T_CD_States_DAO()
        {
            _StateId = 0;
        }

        public T_CD_States_DAO(int StateId)
        {
            _StateId = StateId;
        }

        public T_CD_States_DAO(int StateId, string StateName)
        {
            _StateId = StateId;
            _StateName = StateName;

        }

        #endregion

        #region properties

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

        public string StateName
        {
            get
            {
                return _StateName;
            }


            set
            {
                _StateName = value;
            }

        }

        #endregion

        protected DataSet DAOGetAllStatesAndRowId()
        {
            Database db = DatabaseFactory.CreateDatabase("ApplicationDataServices");
            string sqlCommand = "usp_GetAllStatesAndRowId";
            DbCommand dbCommandWrapper = db.GetStoredProcCommand(sqlCommand);
            return db.ExecuteDataSet(dbCommandWrapper);
        }
    }
}
