using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


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

        // додаємо товари в комбобокс
         public void skladLoad()
        {
            Form2 frm2 = new Form2 (this);
            foreach (var tov in orders)
            {
                frm2.comboBox1.Items.Add(tov);               
            }
            frm2.Show();
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
