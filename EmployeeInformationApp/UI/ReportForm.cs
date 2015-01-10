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
using EmployeeInformationApp.GateWay;

namespace EmployeeInformationApp.UI
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
            showOnlistView();
        }

        public void showOnlistView()
        {
            Employee aEmployee = new Employee();
            List<Employee> employees = new List<Employee>();
            EmployeeBll aEmployeeBll = new EmployeeBll();

            employees = aEmployeeBll.GetAllEmployee();
            showAllListView.Items.Clear();
            foreach (Employee employee in employees)
            {
                ListViewItem aListViewItem = new ListViewItem();
                aListViewItem.Text = employee.Id.ToString();
                aListViewItem.SubItems.Add(employee.Name);
                aListViewItem.SubItems.Add(employee.Email);
                showAllListView.Items.Add(aListViewItem);
            }
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            
            string name=findTextBox.Text;

            Employee aEmployee=new Employee();
            EmployeeBll aEmployeeBll = new EmployeeBll();
            showAllListView.Items.Clear();
            aEmployee = aEmployeeBll.GetEmployee(name);
            ListViewItem aListViewItem=new ListViewItem();
            aListViewItem.Text = aEmployee.Id.ToString();
            aListViewItem.SubItems.Add(aEmployee.Name);
            aListViewItem.SubItems.Add(aEmployee.Email);
            showAllListView.Items.Add(aListViewItem);

        }
    }
}
