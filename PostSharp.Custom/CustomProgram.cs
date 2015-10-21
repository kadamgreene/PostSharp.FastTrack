using PostSharp.Custom.Services;

namespace PostSharp.Custom
{
    class CustomProgram
    {
        static void Main(string[] args)
        {
            GreetingsService service = new GreetingsService();
            service.SayHello("Adam");

            service.SayGoodbye("Adam");
        }
    }
}
