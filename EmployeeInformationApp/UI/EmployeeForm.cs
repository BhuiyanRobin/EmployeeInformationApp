using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeInformationApp.BLL;
using EmployeeInformationApp.DAL.DAO;

namespace EmployeeInformationApp
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
            degignationComboBox.DisplayMember = "Code";
            DegignationAddToCombobox();
        }
        Employee aEmployee=new Employee();
        EmployeeBll aEmployeeBll = new EmployeeBll();

        void TakeInput()
        {
            aEmployee.Address = addressRichTextBox.Text;
            aEmployee.Email = emailTextBox.Text;
            aEmployee.Name = nameTextBox.Text;
            aEmployee.ADesignation.Code = degignationComboBox.Text;
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            
           
            TakeInput();
            string message=aEmployeeBll.InsertIntoDatabase(aEmployee);
            MessageBox.Show(message);

        }

        void DegignationAddToCombobox()
        {
            List<Designation> designations=new List<Designation>();
            designations=aEmployeeBll.AllDesignations();
            degignationComboBox.DataSource = designations;

            //foreach (Designation designation in designations)
            //{
            //    degignationComboBox.Items.Add(designation);
            //}
        }
       
    }
}
