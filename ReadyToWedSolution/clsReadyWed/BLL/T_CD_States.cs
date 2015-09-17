using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace clsReadyWed.BLL
{
    public class T_CD_States : DAL.T_CD_States_DAO
    {
        #region Constructors


        public T_CD_States()
        {
        }

        public T_CD_States(int StateId)
            : base(StateId)
        {
        }


        public T_CD_States(int StateId, string StateName)
            : base(StateId, StateName)
        {
        }

        #endregion

        public DataSet GetAllStatesAndRowId()
        {
            return base.DAOGetAllStatesAndRowId();
        }
    }
}
