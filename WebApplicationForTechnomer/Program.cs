using System.Net;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;
using System.Web;
using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.AspNetCore.Server.Kestrel.Https;
//using Microsoft.EntityFrameworkCore;
using WebApplicationForTechnomer.Models;
using Microsoft.Extensions.Options;
//using Npgsql;

//connectionStrings.Info = "Data Source = localhost; initial catalog"
var builder = WebApplication.CreateBuilder(args);

//string connection = builder.Configuration.GetConnectionString("DefaultConnection");
 
// добавляем контекст ApplicationContext в качестве сервиса в приложение
//builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connection));
// builder.Services.AddHttpContextAccessor<ApplicationContext>
// (options => options.UseNpgsql(builder.Configuration.GetConnectionString("")));

// builder.Services.AddDbContext<ApplicationContext>(options =>
//     options.UseNpgsql(builder.Configuration.GetConnectionString("MvcMovieContext")));

// static void PostgreSQLConnection()
//         {
//             string strConnString = "Host = localhost; Port = 5432; Database = TaskManager; Username = postgres; Password = s5!sz52x";//"Host = localhost; Port = 5432; Database = TaskManager; Username = postgres; Password = s5!sz52x"
//             try
//             {
//                 NpgsqlConnection objpostgraceConn = new NpgsqlConnection(strConnString);
//                 objpostgraceConn.Open();
//                 string strpostgracecommand = "select employeeid , employeename , employeesalary  from employee";
//                 NpgsqlDataAdapter objDataAdapter = new NpgsqlDataAdapter(strpostgracecommand, objpostgraceConn);
//                 objpostgraceConn.Close();
//             }
//             catch (Exception ex)
//             {
//                 Console.WriteLine("Ошибка в подключении");
//             }
//         }

var env = builder.Environment;

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddAuthorization();
builder.Services.AddHttpContextAccessor();
builder.Services.AddDistributedMemoryCache();
builder.Services.AddMvc();
builder.Services.AddMemoryCache();
builder.Services.AddControllers();

var app = builder.Build();

 if (env.IsDevelopment())
 {
app.UseDeveloperExceptionPage();
 }

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    //builder.Services.Configure
    app.UseDeveloperExceptionPage();
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
else {
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseForwardedHeaders();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
