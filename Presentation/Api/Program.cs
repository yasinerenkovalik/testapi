using Persistence;
using Api.Application2;
using Api.Mapper;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers(); //i de bu
builder.Services.AddSwaggerGen();


builder.Services.AddPersistence(builder.Configuration);
builder.Services.AddApplication();
builder.Services.AddCustomMapper();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();//bu ve yu karı da .net 8 ya da rider yü zün den ekl en miy or 404 hat ası ver iy or

app.UseCors("AllowAllOrigins");


app.Run();

