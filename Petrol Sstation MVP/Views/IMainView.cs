using Petrol_Station_MVP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petrol_Station_MVP.Views
{
    public interface IMainView
    {
        string GasolineText { get; set; }
        string PriceText { get; set; }
        string ByGallonText { get; set; }
        string ByCashText { get; set; }
        string ResultPrice { get; set; }

        List<PetrolStation> PetrolStations { set; }

        EventHandler<EventArgs> CalculateButtonClicked { get; set; }
    }
}
