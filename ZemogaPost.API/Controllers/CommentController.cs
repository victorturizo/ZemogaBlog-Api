using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZemogaPost.Business.Interfaces.Services;
using ZemogaPost.Domain.Entities;

namespace ZemogaPost.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ICommentService commentService;

        public CommentController(ICommentService commentService)
        {
            this.commentService = commentService;
        }

        [HttpGet("GetAllComments")]
        public async Task<IActionResult> GetAllComments()
        {
            return Ok(await this.commentService.GetAll());
        }

        [HttpPost("SaveComment")]
        public async Task<IActionResult> SaveComment([FromBody]Comment comment)
        {
            return Ok(await this.commentService.Create(comment));
        }

        [HttpPost("GetCommentById")]
        public async Task<IActionResult> GetCommentById([FromBody] int Id)
        {
            return Ok(await this.commentService.GetById(Id));
        }

        [HttpPost("GetCommentByPostId")]
        public async Task<IActionResult> GetCommentByPostId([FromBody] int Id)
        {
            return Ok(await this.commentService.GetAllCommentsByPostId(Id));
        }

        [HttpPost("UpdateComment")]
        public async Task<IActionResult> UpdateComment([FromBody] Comment comment)
        {
            return Ok(await this.commentService.Update(comment, comment.Id));
        }
    }
}
