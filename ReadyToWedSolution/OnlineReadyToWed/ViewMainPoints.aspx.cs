using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Globalization;
using System.Web.Services;
using clsReadyWed;
using System.Web.UI.HtmlControls;
using System.Configuration;


public partial class _Default : System.Web.UI.Page
{
    clsReadyWed.BLL.MainPoints MainPoints = new clsReadyWed.BLL.MainPoints();
    clsReadyWed.BLL.HelpLines HelpLines = new clsReadyWed.BLL.HelpLines();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillDropDown();
            FillHeaderMesage();
        }
    }

    protected void FillDropDown()
    {
        //Fill Main Points dropdownlist
        System.Data.DataSet ds = MainPoints.GetAllMainPoints();
        if (ds.Tables != null && ds.Tables.Count > 0)
        {
            DataTable dt = ds.Tables[0];
            if (dt.Rows != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    this.ddlMainPoint.DataTextField = "MainPoint";
                    this.ddlMainPoint.DataValueField = "MainPointId";
                    this.ddlMainPoint.DataSource = dt;
                    this.ddlMainPoint.DataBind();                   
                }
                this.ddlMainPoint.Items.Insert(0, new ListItem("Select One", "0"));
            }
        }
    }

    protected void FillHeaderMesage()
    {
        System.Data.DataSet ds = HelpLines.GetHelpLineMessageById(3);
        if (ds.Tables != null && ds.Tables.Count > 0)
        {
            DataTable dt = ds.Tables[0];
            if (dt.Rows != null && dt.Rows.Count > 0)
            {
                this.lblHelpMessage3.Text = dt.Rows[0]["HelpLineMessage"].ToString();
            }
        }
    }

    protected void ddlMainPoint_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }

    protected void ddlMainPoint_TextChanged(object sender, EventArgs e)
    {
        try
        {
            this.lblMainPointDescription.Text = "";

            int n;
            bool isNumeric = int.TryParse(this.ddlMainPoint.SelectedValue, out n);

            if (isNumeric)
            {
                System.Data.DataSet ds = MainPoints.GetMainPointDescriptionByRowId(Convert.ToInt32(this.ddlMainPoint.SelectedValue));
                if (ds.Tables != null && ds.Tables.Count > 0)
                {
                    DataTable dt = ds.Tables[0];
                    if (dt.Rows != null && dt.Rows.Count > 0)
                    {
                        this.lblMainPointDescription.Text = dt.Rows[0]["MainPointDescription"].ToString();
                    }
                }
            }
        }
        catch (Exception ex)
        {

        }
    }
}