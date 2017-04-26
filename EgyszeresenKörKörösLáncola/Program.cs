using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgyszeresenKörKörösLáncola
{
    class Program
    {
        static void kiir(KörKláncolás<Teszt>KKL)

        {
            for (int i = 0; i < KKL.count; i++)
                Console.WriteLine(KKL[i].toString());
            Console.WriteLine("--------------");

        }


        static void Main(string[] args)
        {
            KörKláncolás<Teszt> KKL =
                new KörKláncolás<Teszt>();

            KKL.Add(new Teszt()
            {
                Text = "0"
            });
            kiir(KKL);
            KKL.Add(new Teszt()
            {
                Text = "1"
            });
            kiir(KKL);

            KKL.Add(new Teszt()
            {
                Text = "2"
            });
            kiir(KKL);

            KKL.Add(new Teszt()
            {
                Text = "3"
            });
            kiir(KKL);

            KKL.Insert(1, new Teszt()

            {
                Text = "01"
            });
            kiir(KKL);

            try
            {
                KKL.Delete(6);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            KKL.Delete(1);
            kiir(KKL);


            Console.ReadKey();


        }
    }
}
