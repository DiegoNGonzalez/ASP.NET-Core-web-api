using Backend_api.DTOs;

namespace Backend_api.Services
{
    public interface IPostsService
    {
        public Task<IEnumerable<PostDto>> Get();
    }
}
