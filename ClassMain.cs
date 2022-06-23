using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NOMINA
{
    internal class ClassMain
    {
        
        public static void Main(string[] args)
        {
            Registro no = new Registro();
            int op1=0;
            do
            {
                try
                {
                    Console.WriteLine("----- Hi Welcome!!! -----");
                    Console.WriteLine("Enter the employee's data \n");
                    no.registro();
                    no.screen();
                    Console.WriteLine("-------------------");
                    Console.WriteLine("would you like to repeat this program whit other employee");
                    Console.WriteLine("1. Yes");
                    Console.WriteLine("2. No");
                    op1 = int.Parse(Console.ReadLine());
                    Console.Clear();
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine("-------------------");
                    Console.WriteLine("Invalid Character");
                    Console.WriteLine("Try again \n");
                    
                }
                

            } while (op1 != 2);
            {
                no.FinalData();
            }
            
        }  
    }
}
