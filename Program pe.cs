using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_calculo_de_días
{ // Año = 365.25 dias
    //Meses tienen 30.637
    class Program
    {
        static void Main(string[] args)
        {
            string ano_1, mes_1, dia_1, ano_2, mes_2, dia_2 = " ";
            double conv_ano_1, conv_mes_1, conv_dia_1, conv_ano_2, conv_mes_2, conv_dia_2, dif_ano, dif_mes, dif_dia, Res = 0;
            Console.WriteLine("Calculador de días vividos: ");
            Console.WriteLine("Escriba la fecha actual: ");
            Console.WriteLine("Escriba en día actual: ");
            dia_1 = Console.ReadLine();
            Console.WriteLine("Escriba en mes actual: ");
            mes_1 = Console.ReadLine();
            Console.WriteLine("Escriba en año actual: ");
            ano_1 = Console.ReadLine();

            Console.WriteLine("Escriba el fecha de nacimiento: ");
            Console.WriteLine("Escriba en día de nacimineto: ");
            dia_2 = Console.ReadLine();
            Console.WriteLine("Escriba en mes de nacimiento: ");
            mes_2 = Console.ReadLine();
            Console.WriteLine("Escriba en año de nacimiento: ");
            ano_2 = Console.ReadLine();

            conv_ano_1 = Convert.ToSingle(ano_1);
            conv_mes_1 = Convert.ToSingle(mes_1);
            conv_dia_1 = Convert.ToSingle(dia_1);
            conv_ano_2 = Convert.ToSingle(ano_2);
            conv_mes_2 = Convert.ToSingle(mes_2);
            conv_dia_2 = Convert.ToSingle(dia_2);

            dif_ano = conv_ano_1 - conv_ano_2;
            dif_mes = conv_mes_1 - conv_mes_2;
            dif_dia = conv_dia_1 - conv_dia_2;

            Res = (dif_ano * 365) + (dif_mes * 30) + dif_dia;

            Console.WriteLine("Dias vividos: {0}", Res);
            Console.ReadKey();


        }
    }
}
