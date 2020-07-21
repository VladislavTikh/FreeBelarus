﻿using FreeBelarus.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeBelarus.Server.Services
{
    public interface INewsFeedService
    {
        Task<IEnumerable<Post>> GetAllPosts();
    }
}