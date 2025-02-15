using System;
using System.Globalization;

Console.Write("Ingrese una fecha en formato dd/mm/yyyy: ");
string fechaStr = Console.ReadLine();

DateTime fecha = DateTime.ParseExact(fechaStr, "dd/MM/yyyy", CultureInfo.InvariantCulture);

Console.WriteLine("Fecha en formato largo: " + fecha.ToString("dddd, dd MMMM yyyy"));
