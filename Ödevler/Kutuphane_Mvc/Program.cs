using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
/*
1) SqlServer Paketi: SqlServer için 
    dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.0.15

2) Tools Paketi: scaffold gibi komutları kullanabilmek için
    dotnet add package Microsoft.EntityFrameworkCore.Tools --version 5.0.15

3) Design Paketi: Controllerı otomatik eklemek için
    dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 5.0.2

4) 
*/
namespace EF_Core_MVC_Code
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
