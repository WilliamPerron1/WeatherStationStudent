using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Commands;
using WeatherApp.Models;
using WeatherApp.Services;

namespace WeatherApp.ViewModels
{
    public class WindDataViewModel : BaseViewModel
    {
        /// TODO : Ajoutez le code nécessaire pour réussir les tests et répondre aux requis du projet

        public DelegateCommand<string> GetDataCommand { get; set; }
        public IWindDataService WindDataService;
        public WindDataModel CurrentData { get; set; }


        public double MPStoKPH(double mps)
        {
            double kmh = mps * 3.6;
            return kmh;


        }

        public double KPHtoMPS(double kmh)
        {
            double mps = kmh *1000/3600;
            mps =Math.Round(mps, 2);
            return mps;
        }

        public void GetDataCommandFonction(string s)
        {
            if (WindDataService == null)
            {
                throw new NullReferenceException();
            }
        }

        public bool CanGetData()
        {
            if (WindDataService == null)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }

        public void SetWindDataService(IWindDataService windDataService)
        {
            WindDataService = windDataService;
        }
    }
}
