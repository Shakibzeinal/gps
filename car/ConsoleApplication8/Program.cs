using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Model : ");
            string model = Console.ReadLine();
            Console.Write("Enter Rang : ");
            string rang = Console.ReadLine();
            Console.Write("Enter Speed : ");
            int year = Convert.ToInt32(Console.ReadLine());


            Car st = new Car(model,rang,speed);
            //st.set_color(rang);
            //st.set_mod(model);
            //st.set_speed(soraat);


            //Console.WriteLine(
            //    st.get_rang() + "  " +
            //    st.get_model() + "  " + 
            //    st.get_speed());

            Console.WriteLine(st.Who());
            Console.ReadKey();
        }
    }
}
