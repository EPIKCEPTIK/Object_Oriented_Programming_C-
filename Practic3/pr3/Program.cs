using Microsoft.EntityFrameworkCore;
using practic3.Data;

var builder = WebApplication.CreateBuilder( args );


builder.Services.AddDbContext<AppDbContext>( options =>
	options.UseSqlite( builder.Configuration.GetConnectionString( "DefaultConnection" ) ) );

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


if ( app.Environment.IsDevelopment() )
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();