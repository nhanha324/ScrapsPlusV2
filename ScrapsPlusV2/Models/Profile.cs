using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrapsPlusV2.Models
{
    public class Profile
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public DateTime JoinDate { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string RecoveryEmail { get; set; }
        //Membership is bronze, silver, gold, or nonmember
        public int MembershipLevelID { get; set; }
        //this will be active or inactive whether they have a subscription
        public int SubscriptionStatusID { get; set; }
     

    }
}
