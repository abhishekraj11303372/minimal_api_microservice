using minimal_api_microservice.Model;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/employee", (Func<Employee>)(() => {
    return new Employee()
    {
        Name = "Abhishek",
        location = "India",
        Id = "1"
    };
}));

app.Run();
