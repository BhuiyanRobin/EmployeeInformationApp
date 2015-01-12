namespace EmployeeInformationApp.DAL.DAO
{
    class Employee
    {
        public string Name { set; get; }
        private string email;
        public string Address { set; get; }
        public Designation ADesignation { set; get; }
        public int Id { set; get; }

        public Employee()
        {
            ADesignation=new Designation();
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
