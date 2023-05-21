using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApplication8
{
    class Car
    {
        private string model;
        private string rang;
        private int year;
        private int soraat;


        public Car(string mod, string color, int year, int speed)
        {
            set_model(mod);
            set_rang(color);
            set_soraat(speed);
        }

        public void set_model(string mod_)
        {
            this.model = mod_;
        }
        public void set_rang(string color)
        {
            this.rang = color;
        }
        public void set_year(int y)
        {
            PersianCalendar pc = new PersianCalendar();
            int curr_year = pc.GetYear(System.DateTime.Now);
            this.year = curr_year - y;
        }

        public void set_soraat(int speed)
        {
            this.soraat = speed;

        }


        public string get_model()
        {
            return model;
        }
        public string get_rang()
        {
            return rang;
        }
        public int get_year()
        {
            return year;
        }
        public int get_soraat()
        {
            return soraat;
        }

        public string Who()
        {
            return "rang=" + get_rang() + "  model=" + get_model() + "year=" + get_model() + "  soraat=" + get_soraat();    
        }
    }
}
