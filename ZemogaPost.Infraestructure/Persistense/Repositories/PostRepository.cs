using System;
using System.Collections.Generic;
using System.Text;
using ZemogaPost.Business.Interfaces.Repositories;
using ZemogaPost.Domain.Entities;
using ZemogaPost.Infraestructure.Persistense.Context;

namespace ZemogaPost.Infraestructure.Persistense.Repositories
{
    public class PostRepository:GenericRepository<Post>, IPostRepository
    {
        public PostRepository(BlogDbContext context) : base(context)
        {

        }
    }
}
