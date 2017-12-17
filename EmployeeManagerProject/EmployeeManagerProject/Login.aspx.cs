using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using BEL_EMPMan;
using BLL_EMPMan;


namespace EmployeeManagerProject
{
    public partial class Login : System.Web.UI.Page
    {
        #region creating the object
        Register_BEL objbel = new Register_BEL();
        Register_BLL objbll = new Register_BLL();
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Label lblmastertext = (Label)Master.FindControl("lblmaster");
                lblmastertext.Text = "Employee Manager Project";
                lblstatus.Text = string.Empty;
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            objbel.USERNAME = txtUsername.Text;
            objbel.PASSWORD = txtPassword.Text;
            DataSet ds = new DataSet();
            try
            {
                ds = objbll.Loginuser(objbel);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Session["userid"] = Convert.ToInt32(ds.Tables[0].Rows[0]["userid"].ToString());
                    Response.Redirect("EmpDetail.aspx", false);
                   
                    
                }
                else
                {
                    lblstatus.Text = "Invalid Username or Password";
                    lblstatus.ForeColor = System.Drawing.Color.Red;

                }
            }
            catch (Exception ex)
            {
                ExceptionLogging.SendErrorToText(ex);
                Response.Write("Error in code :" + ex.Message.ToString());
                
            }
            finally
            {
                objbel = null;
                objbll = null;
            }
        }
    }
}