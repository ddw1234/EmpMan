using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BEL_EMPMan;
using DAL_EMPMan;

namespace BLL_EMPMan
{
    public class EmpDetail_BLL
    {
        public DataSet FillDepartment()
        {
            EmpDetail_DAL objempdal = new EmpDetail_DAL();
            try
            {
                return objempdal.FillDepartment();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objempdal = null;
            }

        }

        public Int32 InsertEmpDetail(EmpDetail_BEL objbel)
        {
            EmpDetail_DAL objdal = new EmpDetail_DAL();
            try
            {
               return  objdal.InsertEmpDetail(objbel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objdal = null;
            }
        }

        public DataSet FillGridview()
        {
            EmpDetail_DAL objdal = new EmpDetail_DAL();
            try
            {
                
                return objdal.FillGridview();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objdal = null;
            }
        }

        public DataSet Fetchdatausinggrid(EmpDetail_BEL objempbel)
        {
            EmpDetail_DAL objdal = new EmpDetail_DAL();
            try
            {
                return objdal.Fetchdatausinggrid(objempbel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objdal = null;
            }

        }

        public Int32 UpdateEmpDetail(EmpDetail_BEL objbel)
        {
            EmpDetail_DAL objdal = new EmpDetail_DAL();
            try
            {
                return objdal.UpdateEmpDetail(objbel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objdal = null;
            }
        }
        public Int32 Deleterecord(EmpDetail_BEL objbel)
        {
            EmpDetail_DAL objdal = new EmpDetail_DAL();
            try
            {
                return objdal.Deleterecord(objbel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objdal = null;
            }

        }
    }
}
