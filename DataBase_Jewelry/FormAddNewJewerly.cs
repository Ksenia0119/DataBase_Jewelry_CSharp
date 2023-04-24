///реализация простой базы данных ювелирных изделии
///author Maltseva K.V.


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase_Jewelry
{
    public partial class FormAddNewJewerly : Form
    {
        public FormAddNewJewerly()
        {
            InitializeComponent();
        }

        //добавить изделие,проверка исключений
        private void button_AddNew_Click(object sender, EventArgs e)
        {

            ///цвет ошибочных полей 
            Color error = Color.FromArgb(252, 187, 187);
            ///цвет полей обычный
            Color usual = Color.White;
            //Объект mainForm  ссылается на главную форму
            MainForm mainForm = Owner as MainForm;

            string name = textBox_name.Text;
            string type = textBox_type.Text;
            string composition = textBox_composition.Text;
            double weight;
            double price;
            //для определения налиячия ошибки
            bool hasError = false;

            if (string.IsNullOrWhiteSpace(name))
            {
                textBox_name.BackColor = error;
                hasError = true;
            }
            else
            {
                textBox_name.BackColor = usual;
            }

            if (string.IsNullOrWhiteSpace(type))
            {
                textBox_type.BackColor = error;
                hasError = true;
            }
            else
            {
                textBox_type.BackColor = usual;
            }

            if (string.IsNullOrWhiteSpace(composition))
            {
                textBox_composition.BackColor = error;
                hasError = true;
            }
            else
            {
                textBox_composition.BackColor = usual;
            }

            if (!double.TryParse(textBox_weight.Text, out weight))
            {
                textBox_weight.BackColor = error;
                hasError = true;
            }
            else
            {
                textBox_weight.BackColor = usual;
            }

            if (!double.TryParse(textBox_price.Text, out price))
            {
                textBox_price.BackColor = error;
                hasError = true;
            }
            else
            {
                textBox_price.BackColor = usual;
            }

            if (hasError)
            {
                label_error.Text = "Заполните все поля";
            }
            else
            {
                //Если ошибок не найдено, все введенные поля очищаются
                textBox_name.Clear();
                textBox_type.Clear();
                textBox_composition.Clear();
                textBox_weight.Text = "";
                textBox_price.Text = "";
                ///изделие добавляется в список и на главную форму
                mainForm.jew.AddNewJewerly(name, type, composition, weight, price);
                var n = mainForm.jew.Jewerly.Count;
                mainForm.dataGridView1.Rows.Add(name, type, composition, weight, price);
            }



        }
        //закрыть форму
        private void button_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

      


    }
}
