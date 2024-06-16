﻿using System;
using System.Globalization;

namespace Globalizacao
{
    class program 
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            var pt = new System.Globalization.CultureInfo("pt-BR");
            var atual = CultureInfo.CurrentCulture;

            //Console.WriteLine(DateTime.Now.ToString("D", pt));
            Console.WriteLine(DateTime.Now.ToString("D", atual)); // mostra a data e hora conforme a cultura da máquina que está acessando

            var utcDate = DateTime.UtcNow; //Pega a hora universal
            Console.WriteLine(utcDate);
            Console.WriteLine(utcDate.ToLocalTime()); //Coloca a data da máquina

            var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
            Console.WriteLine(timezoneAustralia);

            var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezoneAustralia);
            Console.WriteLine(horaAustralia);

            var timezones = TimeZoneInfo.GetSystemTimeZones(); //ver todos os timezones registrados no sistema
            foreach (var timezone in timezones)
            {
                Console.WriteLine(timezone.Id);
                Console.WriteLine(timezone);
                Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezone));
                Console.WriteLine("---------------");
            }

        }
    }
}
