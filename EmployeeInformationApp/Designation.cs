using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformationApp
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
