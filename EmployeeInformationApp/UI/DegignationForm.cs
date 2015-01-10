using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeInformationApp
{
    public partial class DegignationForm : Form
    {
        public DegignationForm()
        {
            InitializeComponent();
        }
        Designation aDesignation = new Designation();
        void TakeInput()
        {
            aDesignation.Code = codeTextBox.Text;
            aDesignation.Title = titleTextBox.Text;
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            DesignationBll aDesignationBll=new DesignationBll();
            TakeInput();
            string message=aDesignationBll.InsertIntoDatabase(aDesignation);
            MessageBox.Show(message);
        }
    }
}
