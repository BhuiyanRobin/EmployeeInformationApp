namespace EmployeeInformationApp.DAL.DAO
{
    class Designation
    {
        private string code;
        public string Title { set; get; }

        public string Code
        {
            get { return code; }
            set { code = value; }
        }
    }
}
