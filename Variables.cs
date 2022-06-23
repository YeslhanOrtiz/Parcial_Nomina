using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOMINA
{
    internal class Variables
    {
            private string Document;
            private string First_Name;
            private string Last_Name;
            private double Salary;
            private double Worked_Days;
            private double Basic;
            private double CLMS = 1000000;
            private double TransportAux = 117172;
            private double Devengado;
            private double Health;
            private double Pension;
            private double Tpayroll;

            public Variables() { }

            public string Document1 { get => Document; set => Document = value; }
            public string First_Name1 { get => First_Name; set => First_Name = value; }
            public string Last_Name1 { get => Last_Name; set => Last_Name = value; }
            public double Salary1 { get => Salary; set => Salary = value; }
            public double Worked_Days1 { get => Worked_Days; set => Worked_Days = value; }
            public double Basic1 { get => Basic; set => Basic = value; }
            public double TransportAux1 { get => TransportAux; set => TransportAux = value; }
            public double Devengado1 { get => Devengado; set => Devengado = value; }
            public double Health1 { get => Health; set => Health = value; }
            public double Pension1 { get => Pension; set => Pension = value; }
            public double Tpayroll1 { get => Tpayroll; set => Tpayroll = value; }
            public double CLMS1 { get => CLMS; set => CLMS = value; }
    }
}
