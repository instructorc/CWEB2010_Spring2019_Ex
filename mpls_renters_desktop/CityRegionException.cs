using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace mpls_renters_desktop
{
    class CityRegionException : Exception
    {
        public CityRegionException(string aMessage) : base(aMessage)
        {
            MessageBox.Show(aMessage + " was not one of the 4 Regions");
        }
    }
}
