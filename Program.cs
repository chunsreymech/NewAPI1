using Microsoft.EntityFrameworkCore;
using NewAPI1.Data;

var builder = WebApplication.CreateBuilder(args);

// ១. ចាប់យកខ្សែស្រឡាយតភ្ជាប់ពីឯកសារ appsettings.json
var connectionString = builder.Configuration.GetConnectionString("LimConnection");

// ២. ចុះឈ្មោះ AppDbContext ទៅក្នុង DI Container ដោយប្រាប់វាឱ្យប្រើ SQL Server
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddControllers();
var app = builder.Build();

app.UseAuthorization();
app.MapControllers();
app.Run();