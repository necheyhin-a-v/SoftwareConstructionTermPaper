using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consruction
{
    public partial class formEmployees : Form
    {
        public formEmployees()
        {
            InitializeComponent();
        }

        private void СChoiceRegEmp_Click(object sender, EventArgs e)
        {
            RegistrationEmployee f2 = new RegistrationEmployee();
            f2.ShowDialog();
        }
    }
}
