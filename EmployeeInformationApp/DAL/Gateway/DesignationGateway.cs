using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using EmployeeInformationApp.DAL.DAO;

namespace EmployeeInformationApp.DAL.Gateway
{
    class DesignationGateway
    {
  
        string Connection()
        {
            string connection = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            return connection;
        }

        public bool InsertIntoDatabase(Designation aDesignation)
        {
            SqlConnection aConnection=new SqlConnection(Connection());

            string query = string.Format("INSERT INTO DesignationTable VALUES('{0}','{1}')", aDesignation.Code,
                aDesignation.Title);

            SqlCommand aCommand=new SqlCommand(query,aConnection);
            aConnection.Open();

            int chk = aCommand.ExecuteNonQuery();
            aConnection.Close();
            if (chk > 0)
            {
                return true; 
            }
            else
            {
                return false;
            }
        }

        public List<Designation> GetAllDesignations()
        {
            SqlConnection aConnection = new SqlConnection(Connection());
            List<Designation> designationList=new List<Designation>();
            string query = string.Format("SELECT*FROM DesignationTable");
            
            SqlCommand aCommand=new SqlCommand(query,aConnection);
            aConnection.Open();
            SqlDataReader aReader = aCommand.ExecuteReader();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    Designation aDesignation=new Designation();

                    aDesignation.Code = (string) aReader[1];
                    aDesignation.Title = (string) aReader[2];
                    designationList.Add(aDesignation);
                }
            }
            aConnection.Close();
            return designationList;

        }
        public bool CheckDegignationCodeUniqness(string code)
        {
            SqlConnection aConnection = new SqlConnection(Connection());

            string query = string.Format("SELECT*FROM DesignationTable WHERE(DesigantionCode='{0}')", code);

            SqlCommand aCommand = new SqlCommand(query, aConnection);
            aConnection.Open();
            SqlDataReader aReader = aCommand.ExecuteReader();
            bool chk = aReader.HasRows;
            if (chk==true)
            {
                return true;
            }
            else
            {
                return false;
            }
            

        }
    }
}
