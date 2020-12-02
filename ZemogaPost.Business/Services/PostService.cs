using System;
using System.Collections.Generic;
using System.Text;
using ZemogaPost.Business.Interfaces.Repositories;
using ZemogaPost.Business.Interfaces.Services;
using ZemogaPost.Domain.Entities;

namespace ZemogaPost.Business.Services
{
    public class PostService:GenericService<Post>, IPostService
    {
        
        public PostService(IPostRepository postRepository) : base(postRepository)
        {
            
        }
    }
}
