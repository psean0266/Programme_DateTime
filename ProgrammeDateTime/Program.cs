using System;
using System.Globalization;

namespace ProgrammeDateTime
{
     class Program
    {
        static void Main(string[] args)
        {
             DateTime date = DateTime.Now;
            //   Console.WriteLine(date);
            //    Console.WriteLine(date.Month);


            CultureInfo cultureAnglais = CultureInfo.GetCultureInfo("en-US");
            CultureInfo cultureFrancais = CultureInfo.GetCultureInfo("fr-FR");

            //Console.WriteLine(date.ToString("dd/MM/yyyy"));
            // Console.WriteLine(date.ToString("dd/MM/yyyy HH:mm:ss" ));
            // Console.WriteLine(date.ToString("dddd MMMM yyyy HH:mm:ss"));
            Console.WriteLine(date.ToString("dddd MMMM yyyy HH:mm:ss", cultureFrancais));

            DateTime dateDemain = date.AddDays(1);

            Console.WriteLine("Date de demain : " + dateDemain.ToString("dddd MMMM yyyyy"), cultureFrancais);

            var diff = dateDemain - date;


            Console.WriteLine("Différence de jour : "+ diff.TotalDays);
            Console.WriteLine("Différence heure : " + diff.TotalHours);
        }
    }
}
