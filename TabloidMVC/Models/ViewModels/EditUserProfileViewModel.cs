﻿using System.Collections.Generic;

namespace TabloidMVC.Models.ViewModels
{
    public class EditUserProfileViewModel
    {
        public List<UserType> UserTypes { get; set; }
        public UserProfile UserProfile { get; set; }
        public int DemotionRequests { get; set; }
        public int ExistingDemotionRequesterId { get; set; }
    }
}
