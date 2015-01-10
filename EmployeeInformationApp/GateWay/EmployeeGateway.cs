using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformationApp.GateWay
{
    class EmployeeGateway
    {
        string Connection()
        {
            string connection = @"SERVER=BITM-401-PC25\SQLEXPRESS;DATABASE=EmploeeInformation;INTEGRATED SECURITY=true";
            return connection;
        }

        public bool InsertIntoDatabase(Employee aEmployee)
        {
            SqlConnection aConnection=new SqlConnection(Connection());
            aConnection.ConnectionString = Connection();

            string query = string.Format("INSERT INTO EmployeeTable VALUES('{0}','{1}','{2}','{3}')", aEmployee.Name,
                aEmployee.Email, aEmployee.Address, aEmployee.ADesignation.Code);

            SqlCommand aCommand=new SqlCommand(query,aConnection);

            aConnection.Open();
            int chk = aCommand.ExecuteNonQuery();
            aConnection.Close();
            if (chk>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<Employee> GetAllEmployees()
        {
            SqlConnection aConnection = new SqlConnection(Connection());
            List<Employee> employeeList = new List<Employee>();
            string query = string.Format("SELECT*FROM EmployeeTable");

            SqlCommand aCommand = new SqlCommand(query, aConnection);
            aConnection.Open();
            SqlDataReader aReader = aCommand.ExecuteReader();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    Employee aEmployee=new Employee();

                    aEmployee.Id = (int) aReader[0];
                    aEmployee.Name = (string)aReader[1];
                    aEmployee.Email = (string)aReader[2];
                    employeeList.Add(aEmployee);
                }
            }
            aConnection.Close();
            return employeeList;

        }
        public bool CheckEmployeeEmailUniqness(string email)
        {
            SqlConnection aConnection = new SqlConnection(Connection());

            string query = string.Format("SELECT*FROM EmployeeTable WHERE(Email='{0}')", email);

            SqlCommand aCommand = new SqlCommand(query, aConnection);
            aConnection.Open();
            SqlDataReader aReader = aCommand.ExecuteReader();
            bool chk = aReader.HasRows;
            aConnection.Close();
            if (chk == true)
            {
                return true;
                
            }
            else
            {
                return false;
            }


        }
        public Employee GetEmployee(string name)
        {
            SqlConnection aConnection = new SqlConnection(Connection());
            Employee aEmployee=new Employee();
            string query = string.Format("SELECT*FROM EmployeeTable WHERE(Name='{0}')", name);

            SqlCommand aCommand = new SqlCommand(query, aConnection);
            aConnection.Open();
            SqlDataReader aReader = aCommand.ExecuteReader();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    aEmployee.Id =(int) aReader[0];
                    aEmployee.Name = (string) aReader[1];
                    aEmployee.Email = (string) aReader[2];
                }
            }
            aConnection.Close();
            return aEmployee;
        }

        

        
    }
}
