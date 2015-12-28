using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class AboutAuthors : System.Web.UI.Page
{
    clsReadyWed.BLL.HelpLines HelpLines = new clsReadyWed.BLL.HelpLines();
    protected void Page_Load(object sender, EventArgs e)
    {
        System.Data.DataSet ds = HelpLines.GetHelpLineMessageById(4);
        if (ds.Tables != null && ds.Tables.Count > 0)
        {
            DataTable dt = ds.Tables[0];
            if (dt.Rows != null && dt.Rows.Count > 0)
            {
                this.HelpLine4.Text = dt.Rows[0]["HelpLineMessage"].ToString();
            }
        }
        ds = HelpLines.GetHelpLineMessageById(5);
        if (ds.Tables != null && ds.Tables.Count > 0)
        {
            DataTable dt = ds.Tables[0];
            if (dt.Rows != null && dt.Rows.Count > 0)
            {
                this.HelpLine5.Text = dt.Rows[0]["HelpLineMessage"].ToString();
            }
        }
    }
}