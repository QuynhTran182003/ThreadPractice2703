using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.VisualBasic.FileIO;
using System.Globalization;

namespace Cv2703
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Hrac h = new Hrac("Krixi", 500);
            Thread thread1 = new Thread(new ThreadStart(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    h.DecreaseHealth(new Random().Next(500)+100);
                }
            }
            ));

            Thread thread2 = new Thread(new ThreadStart(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    h.IncreaseHealth(new Random().Next(50));
                }
            }
            ));
            thread1.Start();
            thread2.Start();*/



            var csvConfig = new CsvConfiguration(CultureInfo.CurrentCulture)
            {
                HasHeaderRecord = false,
                Comment = '#',
                AllowComments = true,
                Delimiter = ",",
            };

            using var streamReader = File.OpenText("dluznici.csv");
            using var csvReader = new CsvReader(streamReader, csvConfig);
            while (csvReader.Read())
            {
                var iD = csvReader.GetField(0);
                var rodCislo = csvReader.GetField(1);
                var dluh = csvReader.GetField(2);
                Console.WriteLine($"Id: {iD}, RodCis: {rodCislo}, Dluh: {dluh}");
                //Dluznik d = new Dluznik(int.Parse(id), rodCislo, dluh);
                //Console.WriteLine(d);
            }
        }
    }
}