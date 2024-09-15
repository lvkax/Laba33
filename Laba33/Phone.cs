using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba33
{
    public class Phone
    {
        public string Name;
        public string Model;
        public string Cost;
        public string ReleaseYear;
        public int YearOfPurchase;
        public string BatteryCapacity;
        public bool Has3Cameras;
        public bool HasWirelessCharging;

        public double GaranteEndingYear
        {
            get { return getGaranteEndingYear(); }

        }
        public double getGaranteEndingYear()
        {
            if (Name == "iPhone") return YearOfPurchase + 1;
            else if (Name == "Samsung") return YearOfPurchase + 2;
            else return YearOfPurchase + 3;
        }
    }
}
