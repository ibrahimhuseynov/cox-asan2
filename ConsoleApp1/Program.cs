using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            Grup grups = new Grup();
            Console.WriteLine("enter the student count :");
            grups.StudenLimit = (Convert.ToInt32(Console.ReadLine()));
            if (grups.StudenLimit > 30)
            {
                while (grups.StudenLimit > 30)
                {
                    Console.WriteLine("enter the student count :");
                    grups.StudenLimit = (Convert.ToInt32(Console.ReadLine()));
                }
            }
            else
            {
                Console.WriteLine(grups.StudenLimit);
                Console.ReadLine();
            }
            #endregion
            Grup grupss = new Grup();
            Console.WriteLine(" enter the NO");
            grupss.No = Console.ReadLine();
            if (grupss.No.Length != 5)
            {
                while (grupss.No.Length == 5)
                {
                    Console.WriteLine(" enter the NO");
                    grupss.No = Console.ReadLine();
                }
            }
            else if (grupss.No.Length == 5)
            {
                Console.WriteLine(grupss.No);
            }  

        }
    }
}
