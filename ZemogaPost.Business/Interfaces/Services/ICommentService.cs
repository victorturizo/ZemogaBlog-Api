using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ZemogaPost.Domain.Entities;

namespace ZemogaPost.Business.Interfaces.Services
{
    public interface ICommentService : IGenericService<Comment>
    {
        Task<List<Comment>> GetAllCommentsByPostId(int postId);
    }
}
