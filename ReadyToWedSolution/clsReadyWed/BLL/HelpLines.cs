using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace clsReadyWed.BLL
{
    public class HelpLines : DAL.HelpLines_DAO
    {
        #region Constructors


        public HelpLines()
        {
        }

        public HelpLines(int HelpLineId)
            : base(HelpLineId)
        {
        }


        public HelpLines(int HelpLineId, string HelpLineMessage)
            : base(HelpLineId, HelpLineMessage)
        {
        }

        #endregion

        public DataSet GetHelpLineMessageById(int Id)
        {
            return base.DAOGetHelpLineMessageById(Id);
        }
    }
}
