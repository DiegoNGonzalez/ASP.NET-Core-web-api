using Backend_api.DTOs;
using Backend_api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        IPostsService _titleService;

        public PostsController(IPostsService titleService)
        {
            _titleService = titleService;
        }

        [HttpGet]

        public async Task<IEnumerable<PostDto>> Get() =>
            await _titleService.Get();
    }
}
