﻿using AwesomeCMSCore.Modules.Entities.Entities;
using AwesomeCMSCore.Modules.Entities.ViewModel;

namespace AwesomeCMSCore.Modules.Admin.ViewModels
{
    public class CommentViewModel
    {
        public Post Post { get; set; }
        public CommentDto Comment { get; set; }
        public UserViewModel User { get; set; }
    }
}