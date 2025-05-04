var builder = WebApplication.CreateBuilder(args);

var employees = new List<Employee>();
employees.Add(new Employee { Id = 1, FirstName = "John", LastName = "Doe" });
employees.Add(new Employee { Id = 2, FirstName = "Jane", LastName = "Doe" });

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();

