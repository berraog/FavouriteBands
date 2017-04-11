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
            new Band {Id = 1, ImgSrc = "~/img/1.jpg", Name = "The Cars", Description = "The Cars are an American rock band that emerged from the new wave scene in the late 1970s. The band originated in Boston, Massachusetts, in 1976, with singer, rhythm guitarist and songwriter Ric Ocasek, singer and bassist Benjamin Orr, lead guitarist Elliot Easton, keyboardist Greg Hawkes and drummer David Robinson."},
            new Band {Id = 2, ImgSrc = "~/img/2.jpg", Name = "The Avett Brothers", Description = "The Avett Brothers are an American folk rock band from Mount Pleasant, North Carolina, USA. The band is made up of two brothers, Scott Avett (banjo, lead vocals, guitar, piano, kick-drum) and Seth Avett (guitar, lead vocals, hi-hat) as well as Bob Crawford (double bass, violin) and Joe Kwon (cello). Mike Marsh (drums), Tania Elizabeth (violin) and Paul Defiglia (keyboard, organ) are touring members of the band."},
            new Band {Id = 3, ImgSrc = "~/img/3.jpg", Name = "NWA", Description = "N.W.A (an abbreviation for Niggaz Wit Attitudes) was an American hip hop group from Compton, California. They were among the earliest and most significant popularizers and controversial figures of the gangsta rap subgenre, and are widely considered one of the greatest and most influential groups in the history of hip hop music. Active from 1986 to 1991, the rap group endured controversy owing to their music's explicit lyrics, which many viewed as being disrespectful to women, as well as to its glorification of drugs and crime. The group was subsequently banned from many mainstream American radio stations. In spite of this, the group has sold over 10 million units in the United States alone. The group was also known for their deep hatred of the police system, which sparked much controversy over the years."},
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
