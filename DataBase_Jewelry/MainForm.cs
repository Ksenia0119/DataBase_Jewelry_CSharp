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
    public partial class MainForm : Form
    {   ///поле хранит имя файла для работы 
        public string filename = "";

        ///cсылка на объект класса base_jewerly
        public base_jewerly jew = new base_jewerly();


        public MainForm()
        {
            InitializeComponent();
        }

        ///Заполнение таблицы на форме из объекта jew
        private void WriteToDataGrid()
        {
            for (int i = 0; i < jew.Jewerly.Count; i++)
            {
                Jewerly b = jew.Jewerly[i];
                dataGridView1.Rows.Add(b.GetName(), b.GetTypes(), b.GetComposition(), b.GetWeight(), b.GetPrice());
            }

        }
        ///Открыть новую форму и добавить изделие
        private void button_add_Click(object sender, EventArgs e)
        {
            FormAddNewJewerly addform = new FormAddNewJewerly();
            addform.Owner = this;
            addform.Show();
        }
        ///очиcтить таблицу на форме и объект jew
        private void button_alldelete_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            jew.Jewerly.Clear();
        }
        ///сохранить в фаил
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                if (filename == "")
                {
                    if (saveFileDialog.ShowDialog() == DialogResult.Cancel) return;
                    filename = saveFileDialog.FileName;
                }
                jew.SaveBase(filename);
            }

        }
        ///открыть из файла
        private void открытьБазуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.Cancel) return;

                filename = openFileDialog.FileName;

                dataGridView1.Rows.Clear();
                ///открывает файл и загружает данные в объект jew
                jew.OpenFile(filename);
                //заполняет таблицу на форме
                WriteToDataGrid();
            }
        }
    }
}