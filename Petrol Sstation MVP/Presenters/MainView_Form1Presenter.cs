using Petrol_Station_MVP.Data;
using Petrol_Station_MVP.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Petrol_Station_MVP.Models;

namespace Petrol_Station_MVP.Presenters
{
    public class MainView_Form1Presenter
    {

        private readonly PetrolContext _db;
        public IMainView _view;

        private readonly MainView_Form1 mainView_Form;
        public MainView_Form1Presenter(IMainView view)
        {
            _view = view;

            mainView_Form = new MainView_Form1();
            _db = new PetrolContext();

            _view.CalculateButtonClicked += ViewCalculateButtonClicked;
        }


  

        private void ViewCalculateButtonClicked(object sender, EventArgs e)
        {



            PetrolStation petrol = new PetrolStation
            {
                Gasoline = _view.GasolineText,
                Price = _view.PriceText,
                ByGallon = _view.ByGallonText,
                ByCash = _view.ByCashText,
               ResultPrice = _view.ResultPrice,

            };


   


            _db.PetrolStations.Add(petrol);
            _db.SaveChanges();



            var list = _db.PetrolStations.ToList();

            _view.PetrolStations = list;
        }




    }
}
