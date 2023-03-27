using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv2703
{
    public class Dluznik
    {
        private int id;
        private string rodCis;
        private string dluh;
        [Name("ID")] public int ID { get { return id; } set { id = value; } }
        [Name("RODNE_CISLO")] public string RodCis { get { return rodCis; } set {rodCis = value; } }
        [Name("DLUZNA_CASTKA_CZK")] public string Dluh { get { return dluh; } set { dluh = value; } }

        public Dluznik(int iD, string rodCis, string dluh)
        {
            ID = iD;
            RodCis = rodCis;
            Dluh = dluh;
        }

        public override string? ToString()
        {
            return $"Id: {ID}, RodCis: {RodCis}, Dluh: {Dluh}";
        }
    }
}
