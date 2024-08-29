namespace Assignment_MVC_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers();
            var app = builder.Build();

            app.MapGet("/", () => "Hello World!");
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller}/{action}/{id:int?}/{name:alpha?}"

                );
            app.Run();
        }
    }
}
