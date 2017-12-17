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
    public partial class EmpDetail : System.Web.UI.Page
    {
        #region Creating object
        EmpDetail_BEL objempbel = new EmpDetail_BEL();
        EmpDetail_BLL objempbll = new EmpDetail_BLL();
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Label lblmastertext = (Label)Master.FindControl("lblmaster");
                lblmastertext.Text = "Employee Details";
                FillDepartment();
                FillGridView();
            }
            
        }
        public void FillDepartment()
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
         
            try
            {
                ds=objempbll.FillDepartment();
                dt = ds.Tables[0];
                ddlDepartment.DataSource = dt;
                ddlDepartment.DataTextField = "Deptname";
                ddlDepartment.DataValueField = "DeptId";
                ddlDepartment.DataBind();
                ddlDepartment.Items.Insert(0, new ListItem("Select Department","0"));
               
            }
            catch (Exception ex)
            {
                Response.Write("Error in code :" + ex.Message.ToString());
            }
            

        }

        public void FillGridView()
        {
            DataSet ds = new DataSet();
            try
            {

                ds = objempbll.FillGridview();
                GridView1.DataSource=ds;
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("Error in code :" + ex.Message.ToString());
            }
            
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Clearcontrol();
            FillGridView();
        }

        public void Clearcontrol()
        {
            txtFirstName.Text = string.Empty;
            txtMiddleName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtCity.Text = string.Empty;
            ddlGender.SelectedValue = "Select Gender";
            txtEmailId.Text = string.Empty;
            rdoEmpStatus.ClearSelection();
            ddlDepartment.Items.Clear();
            FillDepartment();
            chkemptype.ClearSelection();
            txtDateOfBirth.Text = string.Empty;
            txtDateOfJoin.Text = string.Empty;
            hdnempId.Value = string.Empty;
            lblMessage.Text = string.Empty;
            lblUserId.Text = string.Empty;
            btnSubmit.Text = "Submit";
           
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (btnSubmit.Text == "Submit")
            {
                try
                {
                    objempbel.FirstName = txtFirstName.Text;
                    objempbel.MiddleName = txtMiddleName.Text;
                    objempbel.LastName = txtLastName.Text;
                    objempbel.Address = txtAddress.Text;
                    objempbel.City = txtCity.Text;
                    objempbel.Gender = ddlGender.SelectedValue;
                    objempbel.Emailid = txtEmailId.Text;
                    objempbel.EmpStatus = rdoEmpStatus.SelectedValue;
                    objempbel.DeptID = Convert.ToInt32(ddlDepartment.SelectedValue);
                    objempbel.EmpType = chkemptype.SelectedItem.Text;
                    objempbel.DateOfBirth = txtDateOfBirth.Text;
                    objempbel.DateofJoin = txtDateOfJoin.Text;


                    int result = objempbll.InsertEmpDetail(objempbel);
                    if (result > 0)
                    {
                        Clearcontrol();
                        lblMessage.Text = "Client Details Sucessfully Saved";
                        lblMessage.ForeColor = System.Drawing.Color.Blue;
                        FillGridView();
                    }
                    else
                    {
                        lblMessage.Text = "clients details not Saved";
                        lblMessage.ForeColor = System.Drawing.Color.Red;
                    }
                }
                catch (Exception ex)
                {
                    Response.Write("Error occured " + ex.Message.ToString());
                }
            }
            else
            {
                try
                {
                    objempbel.EmpId = Convert.ToInt32(hdnempId.Value);
                    objempbel.FirstName = txtFirstName.Text;
                    objempbel.MiddleName = txtMiddleName.Text;
                    objempbel.LastName = txtLastName.Text;
                    objempbel.Address = txtAddress.Text;
                    objempbel.City = txtCity.Text;
                    objempbel.Gender = ddlGender.SelectedValue;
                    objempbel.Emailid = txtEmailId.Text;
                    objempbel.EmpStatus = rdoEmpStatus.SelectedValue;
                    objempbel.DeptID = Convert.ToInt32(ddlDepartment.SelectedValue);
                    objempbel.EmpType = chkemptype.SelectedItem.Text;
                    objempbel.DateOfBirth = txtDateOfBirth.Text;
                    objempbel.DateofJoin = txtDateOfJoin.Text;


                    int result = objempbll.UpdateEmpDetail(objempbel);
                    if (result > 0)
                    {
                        Clearcontrol();
                        lblMessage.Text = "Client Details Sucessfully Updated";
                        lblMessage.ForeColor = System.Drawing.Color.Blue;
                        FillGridView();
                    }
                    else
                    {
                        lblMessage.Text = "clients details not Updated";
                        lblMessage.ForeColor = System.Drawing.Color.Red;
                    }
                }
                catch (Exception ex)
                {
                    Response.Write("Error occured " + ex.Message.ToString());
                }
            }
           
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            Clearcontrol();
            GridView1.PageIndex = e.NewPageIndex;
            FillGridView();
        }

       

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Clearcontrol();
            Label grempid = (Label)GridView1.Rows[e.RowIndex].FindControl("lblgrempid");
            objempbel.EmpId = Convert.ToInt32(grempid.Text);
            Deleterecord(objempbel.EmpId);
            GridView1.EditIndex = -1;
            FillGridView();
        }

        public void Deleterecord(int gridempid)
        {
            objempbel.EmpId = gridempid;
            try
            {
                int result=objempbll.Deleterecord(objempbel);
                if (result > 0)
                {
                    
                    lblMessage.Text = "Client Details Sucessfully Deleted";
                    lblMessage.ForeColor = System.Drawing.Color.Blue;
                }
                else
                {
                    lblMessage.Text = "clients details not Deleted";
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                Response.Write("Error ocuured " + ex.Message.ToString()); 
            }

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Clearcontrol();
            Label grempid = (Label)GridView1.Rows[e.NewEditIndex].FindControl("lblgrempid");
            objempbel.EmpId = Convert.ToInt32(grempid.Text);
            Fetchdataforemp(objempbel.EmpId);
            GridView1.EditIndex = e.NewEditIndex;
            FillGridView();
        }

        public void Fetchdataforemp(int gridempid)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            objempbel.EmpId = gridempid;
            try
            {
                ds = objempbll.Fetchdatausinggrid(objempbel);
                dt = ds.Tables[0];

                hdnempId.Value = dt.Rows[0]["EmpId"].ToString();
                txtFirstName.Text = dt.Rows[0]["Firstname"].ToString();
                txtMiddleName.Text = dt.Rows[0]["Middlename"].ToString();
                txtLastName.Text = dt.Rows[0]["Lastname"].ToString();
                txtAddress.Text = dt.Rows[0]["Address"].ToString();
                txtCity.Text = dt.Rows[0]["City"].ToString();
                ddlGender.SelectedValue = dt.Rows[0]["Gender"].ToString();
                txtEmailId.Text = dt.Rows[0]["EmailId"].ToString();
                rdoEmpStatus.SelectedValue = dt.Rows[0]["Empstatus"].ToString();
                ddlDepartment.SelectedValue = dt.Rows[0]["DeptId"].ToString();

                if (chkemptype.Items[0].Text == dt.Rows[0]["EmpType"].ToString())
                {
                    chkemptype.Items[0].Selected = true;
                }
                else
                {
                    chkemptype.Items[1].Selected = true;
                }

                txtDateOfBirth.Text = dt.Rows[0]["DateOfBirth"].ToString();
                txtDateOfJoin.Text = dt.Rows[0]["DateOfJoin"].ToString();

                btnSubmit.Text = "Update";
            }
            catch (Exception ex)
            {
                Response.Write("Error Occured :" + ex.Message.ToString());
            }
        }

        
       
    }
}