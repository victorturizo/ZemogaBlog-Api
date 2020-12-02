using Microsoft.AspNetCore.Cors;
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
    //[EnableCors("AllowOrigin")]
    public class BlogPostController : ControllerBase
    {
        private readonly IPostService postService;

        public BlogPostController(IPostService postService)
        {
            this.postService = postService;
        }

        [HttpGet("GetAllPost")]
        public async Task<IActionResult>  GetAllPost()
        {
          return Ok(await this.postService.GetAll());
        }

        [HttpPost("SavePost")]
        public async Task<IActionResult> SavePost([FromBody]Post post)
        {
            try
            {
                return Ok(await this.postService.Create(post));
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }

        [HttpPost("GetPostById")]
        public async Task<IActionResult> GetPostById([FromBody]int Id)
        {
            return Ok(await this.postService.GetById(Id));
        }

        [HttpPost("UpdatePost")]
        public async Task<IActionResult> UpdatePost([FromBody] Post post)
        {
            return Ok(await this.postService.Update(post, post.Id));
        }

        [HttpPost("DeletePost")]
        public async Task<IActionResult> DeletePost([FromBody]int id)
        {
            return Ok(await this.postService.Delete(id));
        }
    }
}
