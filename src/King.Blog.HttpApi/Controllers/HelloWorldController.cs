using King.Blog.Application.Blog;
using King.Blog.Application.Contracts.Blog;
using King.Blog.Application.HelloWorld;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc;

namespace King.Blog.HttpApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class HelloWorldController:AbpController
    {
        private readonly IHelloWorldService _helloWorldService;
       // private readonly IBlogService _blogService;
        public HelloWorldController(IHelloWorldService helloWorldService
           // , IBlogService blogService
            )
        {
            _helloWorldService = helloWorldService;
            //_blogService = blogService;
        }
        [HttpGet]
        public string HelloWorld()
        {
            return _helloWorldService.HelloWorld();
        }
      
        /// <summary>
        ///  添加博客
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        //[HttpPost]
        //public async Task<bool> InsertPostAsync([FromBody] PostDto dto)
        //{
        //    return await _blogService.InsertPostAsync(dto);
        //}
    }

}
