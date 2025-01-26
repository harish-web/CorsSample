using CorsSample.IRepositories;
using CorsSample.IServices;
using CorsSample.Repositories;
using CorsSample.Services;


var builder = WebApplication.CreateBuilder(args);


builder.Services.AddTransient<ICourseService, CourseService>();
builder.Services.AddTransient<ICourseRepository, CourseRepository>();

builder.Services.AddControllers();


var app = builder.Build();

app.UseHttpsRedirection();
app.UseRouting();
app.MapDefaultControllerRoute();

app.Run();
