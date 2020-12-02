using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZemogaPost.Business.Interfaces.Repositories;
using ZemogaPost.Domain.Entities;
using ZemogaPost.Infraestructure.Persistense.Context;

namespace ZemogaPost.Infraestructure.Persistense.Repositories
{
    public class CommentRepository: GenericRepository<Comment>, ICommentRepository
    {
        private readonly BlogDbContext _context;
        public CommentRepository(BlogDbContext context) : base(context)
        {
            this._context = context;
        }

        public async Task<List<Comment>> GetAllCommentsByPostId(int postId)
        {
            return await this._context.Comment.Where(x => x.PostId == postId).ToListAsync();
        }
    }
}
