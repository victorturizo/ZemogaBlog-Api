using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ZemogaPost.Domain.Entities;

namespace ZemogaPost.Business.Interfaces.Repositories
{
    public interface ICommentRepository:IGenericRepository<Comment>
    {
        Task<List<Comment>> GetAllCommentsByPostId(int  postId);
    }
}
