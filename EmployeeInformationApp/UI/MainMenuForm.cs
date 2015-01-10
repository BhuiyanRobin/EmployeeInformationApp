using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeInformationApp.UI;

namespace EmployeeInformationApp
{
    public partial class mainMenuForm : Form
    {
        public mainMenuForm()
        {
            InitializeComponent();
        }

        private void addDegignationButton_Click(object sender, EventArgs e)
        {
            DegignationForm aDegignationForm=new DegignationForm();
            aDegignationForm.Show();
        }

        
        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            EmployeeForm aEmployeeForm=new EmployeeForm();
            aEmployeeForm.Show();
        }

        private void reportGenarateButtton_Click(object sender, EventArgs e)
        {
            ReportForm aReportForm=new ReportForm();
            aReportForm.Show();
        }
    }
}
