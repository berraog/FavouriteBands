using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FavouriteBands.Models
{
    static public class DataManager
    {
        static List<Band> bands = new List<Band>
        {
            new Band {Id = 1, Name = "The Cars"},
            new Band {Id = 2, Name = "The Avett Brothers"},
            new Band {Id = 3, Name = "NWA"},
        };

        public static Band GetBandById(int id)
        {
            return bands[id];
        }

        public static Band[] GetAllBands()
        {
            return bands.ToArray();
        }
    }
}
