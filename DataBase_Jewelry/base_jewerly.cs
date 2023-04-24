///реализация простой базы данных ювелирных изделии
///author Maltseva K.V.


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase_Jewelry
{
    ///класс для работы с базой
    public class base_jewerly
    {
        ///список "jew" объектов "Jewerly"
        List<Jewerly> jew = new List<Jewerly>();

        /// Вернуть список
        public List<Jewerly> Jewerly
        {
            get { return jew; }
        }

        /// Добавить изделие список jew
        public void AddNewJewerly(string name, string type, string composition, double weight, double price)
        {
            Jewerly new_jew = new Jewerly(name, type, composition, weight, price);
            jew.Add(new_jew);
        }

        



        /// Сохранить базу в файл
        public void SaveBase(string name)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(name, false, System.Text.Encoding.Unicode))
                {
                    foreach (Jewerly str in jew)
                    {
                        sw.WriteLine(str);
                    }
                }
            }
            catch (ArgumentException e)
            {
                MessageBox.Show("Ошибка сохранения файла: " + e.Message);
            }

        }
        /// Сохранить базу из файла
        public void OpenFile(string name)
        {
            if (!System.IO.File.Exists(name))
                throw new Exception("Файл не существует");

            // Очищаем список jew перед чтением новых данных из файла
            jew.Clear();

            using (StreamReader sw = new StreamReader(name))
            {
                while (!sw.EndOfStream)
                {
                    string str = sw.ReadLine();
                    String[] dataFromFile = str.Split(new String[] { "|" },
                    StringSplitOptions.RemoveEmptyEntries);

                    if (dataFromFile.Length < 5) // если элементов меньше 5, то пропускаем строку
                        continue;

                    string fname = dataFromFile[0];
                    string ftype = dataFromFile[1];
                    string fcomposition = dataFromFile[2];
                    double fweight = double.Parse(dataFromFile[3]);
                    double fprice = double.Parse(dataFromFile[4]);

                    // Добавляем данные в список
                    AddNewJewerly(fname, ftype, fcomposition, fweight, fprice);
                }
            }
        }
        //удаляет элемент из списка jew по индексу 
        public void DeleteOne(int ind)
        {
            jew.RemoveAt(ind);
        }
    }

    

    
}