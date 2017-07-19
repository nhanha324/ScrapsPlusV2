using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrapsPlusV2.Models
{
    public class Photo
    {
        public int ID { get; set; }
        //route to the photo on the server
        public string Route { get; set; }
        //this identifies what user the photo belongs to
        public int ProfileID { get; set; }
        //this identifies what album the photo belongs to
        public int AlbumID { get; set; }


    }
}
