using minimal_api_microservice.Model;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/employee", (Func<Employee>)(() =>
{
    return new Employee()
    {
        Name = "Abhishek",
        location = "India",
        Id = "1"
    };
}));

app.MapGet("/employees", (Func<List<Employee>>)(() =>
{
    return new EmployeeCollection().GetEmployees();
}));

app.MapGet("/employee/{id}", async (http) =>
{
    if (!http.Request.RouteValues.TryGetValue("id", out var id))
    {
        http.Response.StatusCode = 400;
    }
    else
    {
        await http.Response.WriteAsJsonAsync(new EmployeeCollection()
            .GetEmployees()
            .FirstOrDefault(x => x.Id == (string)id));
    }
});

app.Run();
