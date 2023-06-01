using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace OnlineShopping2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            builWebHost(args).Run();
        }

        public static IWebHost builWebHost(string[] args) =>
           WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>()
            .UseDefaultServiceProvider(options =>
            options.ValidateScopes = false)
            .Build();
    }
}
