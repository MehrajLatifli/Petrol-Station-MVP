using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petrol_Station_MVP.Models
{
    public class PetrolStation
    {
        [Key]
        public int PetrolId { get; set; }
        public string Gasoline { get; set; }
        public string Price { get; set; }
        public string ByGallon { get; set; }
        public string ByCash { get; set; }
        public string ResultPrice { get; set; }

        DateTime time = DateTime.Now;

        MainView_Form1 MainView_Form1 = new MainView_Form1();



        public override string ToString()
        {
            return $"{Gasoline}  \t  {ResultPrice}";
        }
    }
}
