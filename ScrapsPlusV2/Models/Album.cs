using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrapsPlusV2.Models
{
    public class Album
    {
        public int ID { get; set; }
        //this identifies which user this album belongs to
        public int ProfileID { get; set; }
        public string AlbumName { get; set; }

    }
}
