using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data;

namespace clsReadyWed.BLL
{
    public class MainPoints : DAL.MainPoints_DAO
    {
        #region Constructors


        public MainPoints()
        {
        }

        public MainPoints(int MainPointId)
            : base(MainPointId)
        {
        }


        public MainPoints(int MainPointId, string MainPoint, string MainPointDescription)
            : base(MainPointId, MainPoint, MainPointDescription)
        {
        }

        #endregion

        public DataSet GetAllMainPoints()
        {
            return base.DAOGetAllMainPoints();
        }

        public DataSet GetMainPointDescriptionByRowId(int Id)
        {
            return base.DAOGetMainPointDescriptionByRowId(Id);
        }
    }
}
