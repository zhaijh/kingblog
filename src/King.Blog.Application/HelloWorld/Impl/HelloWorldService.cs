namespace King.Blog.Application.HelloWorld.Impl
{
    public class HelloWorldService : KingBlogApplicationServiceBase, IHelloWorldService
    {
        public string HelloWorld()
        {
            return "Hello World";
        }
    }
}
