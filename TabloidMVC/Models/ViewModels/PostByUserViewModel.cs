﻿using System.Collections.Generic;

namespace TabloidMVC.Models.ViewModels
{
    public class PostByUserViewModel
    {
        public List<Post> Post { get; set; }
        public List<UserProfile> UserProfiles { get; set; }

        public List<Category> Categories { get; set; }
        public List<Tag> Tags { get; set; }
    }
}
