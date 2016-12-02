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
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Обработчик входа в систему по клику 
        /// </summary>
        /// <param name="sender">Отправитель события</param>
        /// <param name="e">Аргументы события</param>
        private void EnterInSystem_Click(object sender, EventArgs e)
        {
            if (LoginTB.Text == "moderator")
            {
                this.Hide();
                var f1 = new formEmployers();
                f1.Closed += (s, args) => this.Close();
                f1.Show();
            }

            if (LoginTB.Text == "consultant")
            {
                this.Hide();
                var f2 = new formEmployees();
                f2.Closed += (s, args) => this.Close();
                f2.Show();
            }
        }
    }
}
