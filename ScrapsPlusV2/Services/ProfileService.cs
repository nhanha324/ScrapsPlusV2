using Microsoft.EntityFrameworkCore;
using ScrapsPlusV2.Data;
using ScrapsPlusV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrapsPlusV2.Services
{
    public class ProfileService
    {
        private readonly ApplicationDbContext _contextOptions;

        public ProfileService(ApplicationDbContext contextOptions)
        {
            _contextOptions = contextOptions;
        }


        public Profile AddProfile(Profile newProfile)
        {
            //Adds to the model that we created in the controller
            newProfile.SubscriptionStatusID = 2;
            newProfile.MembershipLevelID = 1;
            newProfile.JoinDate = DateTime.Now;

            //database adds to the profile model
            _contextOptions.Profiles.Add(newProfile);
            _contextOptions.SaveChanges();
            return newProfile;
        }
        

    }
}
