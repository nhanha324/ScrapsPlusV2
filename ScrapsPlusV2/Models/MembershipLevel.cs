using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrapsPlusV2.Models
{
    public class MembershipLevel
    {
        public int ID { get; set; }
        //this shows if they are bronze, silver, gold, or non-member
        public string Level { get; set; }
    }
}
