using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace izvp_lab1
{
     public class bikeShop
    {
        
        string[] BikeShop;
        public static List<string> mark = new List<string>();
        public static List<string> model = new List<string>();
        public static List<string> complectation = new List<string>();
        public static List<int> size = new List<int>();
        public static List<int> diametr = new List<int>();
        public static List<double> score = new List<double>();
        public static List<double> price = new List<double>();

             
       public void mainLoad()
        {
            mark.Clear(); model.Clear(); complectation.Clear();
            size.Clear(); diametr.Clear(); score.Clear(); price.Clear();
            StreamReader reader = new StreamReader("BikeStore.txt", Encoding.Default);
            BikeShop = reader.ReadToEnd().Split(new char[] { '\n', '|', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < BikeShop.Length; i++)
            {
                if (i % 2 == 0)
                    model.Add(BikeShop[i]);
                else price.Add(double.Parse(BikeShop[i]));
            }
            reader.Close();
        }

        public double getPrice(int Index)
        {
            return price[Index];
        }


        // додаємо товари в комбобокс
        public void skladLoad()
        {
            Form2 form2 = new Form2 (this);
            foreach (var tov in mark)
            {
              //  Form2.comboBox1.Items.Add(tov);               
            }
            form2.Show();
        }

        //запись в текстовый файл заказы без скидки
        public void record(string Path, FileMode Mode, string Tovar, string Price)
        {
            FileStream filestream = new FileStream(Path, Mode);
            StreamWriter writer = new StreamWriter(filestream, Encoding.Default);
            writer.WriteLine(Tovar + "|" + Price);
            writer.Close();
        }


        //запись в текстовый файл заказы с учетом скидки
        public void record(string Path, string Tovar, string Price, double Percent)
        {
            FileStream filestream = new FileStream(Path, FileMode.Append);
            StreamWriter writer = new StreamWriter(filestream, Encoding.Default);
            Price = (double.Parse(Price) - double.Parse(Price) * Percent).ToString();
            writer.WriteLine(Tovar + "|" + Price);
            writer.Close();
        }
        //получаем количество строк в текстом файле заказ, чтобы знать сколько нужно нам строк в datagrid
        public int getOrderRowCount
        {
            get
            {
                int count = System.IO.File.ReadAllLines("Order.txt").Length;
                return count;
            }
        }

        public void orderLoad()
        {
            Form3 form3 = new Form3(this);
            form3.dataGridView1.RowCount = getOrderRowCount;
            form3.dataGridView1.ColumnCount = 2;
            int j = 0;f
            int m = 0;
            StreamReader reader = new StreamReader("Order.txt", Encoding.Default);
            mark = reader.ReadToEnd().Split(new char[] { '\n', '|', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < getOrderRowCount * 2; i++)
            {
                if (i % 2 == 0)
                {
                    form3.dataGridView1[0, m].Value = mark[i];
                    m++;
                }
                else
                {
                    form3.dataGridView1[1, j].Value = mark[i];
                    j++;
                }
            }
            reader.Close();
            form3.Show();
        }
    }
}
/*
        private string mark { get; set; }
        private string model { get; set; }
        private string complectation { get; set; }
        // private int size { get; set; }
        private int diametp { get; set; }
        private int score { get; set; }
        // private int price { get; set; }
        
        */
/*
            this.mark = mark;
            this.model = model;
            this.complectation = complectation;
            //this.size = size;
            this.diametp = diametp;
            this.score = score;
           //this.price = price;
           
    */
        
/* string Size ( string sizer)
            {

                if (diametr <= 14)
                {
                    sizer = "S";
                }
                else
                    if (diametr > 14 && diametr <= 16)
                {
                    sizer = "M";

                }
                else
                {
                    sizer = "L";
                }
                return sizer;

            }
           float Price (float price,  int cost, int score)
            {
                if (score == 0)
                {
                    price = cost + cost / 10;
                }
                else
                    if (score > 0 && score <= 3)
                {
                    price = cost + cost / 7;
                }
                else
                    if (score > 3 && score <= 7)
                {
                    price = cost + cost / 5;

                }
                else
                {
                    price = cost + cost / 3;
                }

                if (score > 10 && score < 0) score = 0; 
                return price;
            }*/
