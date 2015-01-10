using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeInformationApp.GateWay;

namespace EmployeeInformationApp.BLL
{
    internal class EmployeeBll
    {
        EmployeeGateway aEmployeeGateway = new EmployeeGateway();
        public string InsertIntoDatabase(Employee aEmployee)
        {
            if (aEmployeeGateway.CheckEmployeeEmailUniqness(aEmployee.Email)==true)
            {
                return "Email Already Exist";

            }
            else
            {
                if (aEmployeeGateway.InsertIntoDatabase(aEmployee) == true)
                {
                    return "sucess";
                }
                else
                {
                    return "Failed";
                }
            }
            
        }
        public List<Designation> AllDesignations()
        {
            DesignationGateway aDesignationGateway = new DesignationGateway();
            return aDesignationGateway.GetAllDesignations();
        }

        public List<Employee> GetAllEmployee()
        {
            return aEmployeeGateway.GetAllEmployees();
        }

        public Employee GetEmployee(string name)
        {

            return aEmployeeGateway.GetEmployee(name);


        }
    }
}

