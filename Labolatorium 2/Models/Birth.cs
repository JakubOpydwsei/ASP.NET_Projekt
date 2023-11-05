using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace Labolatorium_2.Models
{
    public class Birth 
    {

        public string imie { get; set; }
        public DateTime data { get; set; }


        public bool IsValid()
        {
            return !string.IsNullOrEmpty(imie) && data < DateTime.Now;
        }

        public int oblicz_wiek()
        {
            int wiek = DateTime.Now.Year - data.Year;
            if (DateTime.Now.DayOfYear < data.DayOfYear)
            {
                wiek--;
            }
            return wiek;

        }

    }
}
