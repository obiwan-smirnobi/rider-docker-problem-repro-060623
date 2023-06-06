var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();
app.MapGet("/", () =>
{
    return "hello world " + DateTime.Now.Ticks;
});
app.Run("http://0.0.0.0:80");