using System;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Builder;

namespace MeuTodo
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

