using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data;

namespace OLSReadyToWed
{
    public class MainPoints : MainPoints_DAO
    {
        #region Constructors


        public MainPoints()
        {
        }

        public MainPoints(int EventID)
            : base(EventID)
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
    }
}
