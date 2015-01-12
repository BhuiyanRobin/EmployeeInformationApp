using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeInformationApp.DAL.DAO;
using EmployeeInformationApp.DAL.Gateway;

namespace EmployeeInformationApp
{
    class DesignationBll
    {
        public string InsertIntoDatabase(Designation aDesignation)
        {
            DesignationGateway aDesignationGateway=new DesignationGateway();

            if (aDesignationGateway.CheckDegignationCodeUniqness(aDesignation.Code) == true)
            {
                return "Code Already Exist";
            }
            else
            {
                if (aDesignationGateway.InsertIntoDatabase(aDesignation) == true)
                {
                    return "Sucess";
                }
                else
                {
                    return "Failed";
                }
            }
            
        }
    }
}
