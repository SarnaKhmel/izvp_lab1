using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izvp_lab1
{
    class bikeShop
    {
        private string mark { get; set; }
        private string model { get; set; }
        private string complectation { get; set; }
       // private int size { get; set; }
        private int diametp { get; set; }
        private int score { get; set; }
       // private int price { get; set; }
        //private int cost { get; set; }

        public bikeShop(string mark, string model, string complectation, int size, int diametr)
        {
            this.mark = mark;
            this.model = model;
            this.complectation = complectation;
            //this.size = size;
            this.diametp = diametp;
            this.score = score;
           //this.price = price;
           // this.cost = cost;


           string Size ( string sizer)
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
            }

        }

    }
}
