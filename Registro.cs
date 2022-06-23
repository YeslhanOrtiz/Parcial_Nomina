using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NOMINA
{
    internal class Registro
    {
        Variables Datos = new Variables(); 
        public void registro()
        {
            
                Console.WriteLine("Insert document: ");
                Datos.Document1 = Console.ReadLine();
                Console.WriteLine("Insert first name: ");
                Datos.First_Name1 = Console.ReadLine();
                Console.WriteLine("Insert last name: ");
                Datos.Last_Name1 = Console.ReadLine();
                Console.WriteLine("Insert salary: ");
                Datos.Salary1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Insert worked days: ");
                Datos.Worked_Days1 = int.Parse(Console.ReadLine());
                Console.WriteLine("-------------------");
            
            /////////   Operations   /////////////

            //Basic
            Datos.Basic1 = Datos.Salary1 * Datos.Worked_Days1 / 30;
            //Transport Auxiliar
            if (Datos.Salary1 <= (Datos.CLMS1 * 2))
            {
                Datos.TransportAux1 = (Datos.TransportAux1 / 30) * Datos.Worked_Days1;
            }
            else 
            {
                Datos.TransportAux1 = 0; 
            }
            //Devengado
            Datos.Devengado1 = Datos.Basic1 + Datos.TransportAux1;
            //Health
            Datos.Health1 = (Datos.Devengado1 - Datos.TransportAux1)* 0.04;
            //Pension
            Datos.Pension1 = (Datos.Devengado1 - Datos.TransportAux1) * 0.04;
            //Total payroll
            Datos.Tpayroll1 = Datos.Devengado1 - Datos.Health1 - Datos.Pension1;

        }
        public void screen()
        {
            Console.WriteLine($"The Document is:...................... {Datos.Document1}");
            Console.WriteLine($"The First Name is:.................... {Datos.First_Name1}");
            Console.WriteLine($"The Last Name is:..................... {Datos.Last_Name1}");
            Console.WriteLine($"The Salary is:........................ {Datos.Salary1}");
            Console.WriteLine($"The Worked Days is:................... {Datos.Worked_Days1}");
            Console.WriteLine($"The Devengado is:..................... {Datos.Basic1}");
            Console.WriteLine($"The Transport Auxiliar is:............ {Datos.TransportAux1}");
            Console.WriteLine($"The Health is:........................ {Datos.Health1}");
            Console.WriteLine($"The Pension is:....................... {Datos.Pension1}");
            Console.WriteLine("------------------");
            Console.WriteLine($"The Total Payroll is:................. {Datos.Tpayroll1}");

        }
        public void FinalData()
        {
            //El archivo de texto está en la carpeta del proyecto NOMINA\bin\Debug\net6.0

            
            //Creación de archivo
            TextWriter database = new StreamWriter("Employee´s data.txt", true);
            database.WriteLine($"The Document is:...................... {Datos.Document1}");
            database.WriteLine($"The First Name is:.................... {Datos.First_Name1}");
            database.WriteLine($"The Last Name is:..................... {Datos.Last_Name1}");
            database.WriteLine($"The Salary is:........................ {Datos.Salary1}");
            database.WriteLine($"The Worked Days is:................... {Datos.Worked_Days1}");
            database.WriteLine($"The Devengado is:..................... {Datos.Basic1}");
            database.WriteLine($"The Transport Auxiliar is:............ {Datos.TransportAux1}");
            database.WriteLine($"The Health is:........................ {Datos.Health1}");
            database.WriteLine($"The Pension is:....................... {Datos.Pension1}");
            database.WriteLine("------------------");
            database.WriteLine($"The Total Payroll is:................. {Datos.Tpayroll1}\n\n");
            database.Close();

            //Lectura de archivo
            TextReader infodata = new StreamReader("Employee´s data.txt");
            Console.WriteLine(infodata.ReadToEnd);
            infodata.Close();
        }
        
    }
}
