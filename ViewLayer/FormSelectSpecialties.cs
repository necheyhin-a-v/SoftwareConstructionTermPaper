using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewLayer
{
    public partial class FormSelectSpecialties : Form
    {
        private IViewSpecialty ViewSpecialty;
        private IViewEmployee ViewEmployee;
        private string EmployeePassport = "";
        /// <summary>
        /// Конструктор динамической формы
        /// </summary>
        public FormSelectSpecialties(IViewSpecialty viewSpecialty, IViewEmployee viewEmployee)
        {
            try
            {
                this.ViewSpecialty = viewSpecialty;
                this.ViewEmployee = viewEmployee;
                InitializeComponent();
                List<string> specialties = ViewSpecialty.GetSpecialties();
                //Настройка таблицы в ширину
                this.tableLayoutPanelTop.ColumnCount = 4;
                //Добавление последовательно всех специальностей в виде checkBox
                foreach (string item in specialties)
                {
                    CheckBox currentCheckBox = new CheckBox();
                    currentCheckBox.Text = item;
                    this.tableLayoutPanelTop.Controls.Add(currentCheckBox);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Во время работы произошла ошибка") ;
            }

        }
        /// <summary>
        /// Устанавливает на основе работотника все checkBox отмеченные
        /// </summary>
        public void SpecialtiesByEmployee(string passport)
        {
            EmployeePassport = passport;
            try
            {
                //Повторная проверка и выделение checkBox для конкретного работника если нужно
                if (!passport.Equals(""))
                {
                    List<string> selectedSpecialties = ViewEmployee.GetSelectedSpecialties(passport.ToString());
                    foreach (CheckBox item in this.tableLayoutPanelTop.Controls)
                    {
                        if (selectedSpecialties.IndexOf(item.Text) >= 0)
                            item.Checked = true;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка во время выполнения");
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            List<string> result = new List<string>();
            //Формирование списка выбранных специальностей
            foreach (CheckBox item in this.tableLayoutPanelTop.Controls)
                if (item.Checked) result.Add(item.Text);
            if (EmployeePassport.Equals(""))
                ViewEmployee.SetSelectedSpecialties(result);
            else
                ViewEmployee.SetSelectedSpecialties(EmployeePassport, result);
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
