using System.Collections.Generic;

namespace TabloidMVC.Models.ViewModels
{
    public class ManageTagsViewModel
    {
        public List<Tag> Tags { get; set; }

        public List<int> SelectedTags { get; set; }
        public Post Post { get; set; }
    }
}
