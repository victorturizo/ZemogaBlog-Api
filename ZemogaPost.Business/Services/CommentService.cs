using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ZemogaPost.Business.Interfaces.Repositories;
using ZemogaPost.Business.Interfaces.Services;
using ZemogaPost.Domain.Entities;

namespace ZemogaPost.Business.Services
{
    public class CommentService: GenericService<Comment>, ICommentService
    {
        private readonly ICommentRepository commentRepository;
        public CommentService(ICommentRepository commentRepository): base(commentRepository)
        {
            this.commentRepository = commentRepository;
        }

        public Task<List<Comment>> GetAllCommentsByPostId(int postId)
        {
            return this.commentRepository.GetAllCommentsByPostId(postId);
        }
    }
}
