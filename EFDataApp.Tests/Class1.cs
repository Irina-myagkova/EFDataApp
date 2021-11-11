using System;
using NUnit.Framework;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;



namespace EFDataApp.Tests
{
    [TestFixture]
    public class ProjectTest
    {
        [Test]
        public void Program_Test()
        {
            var webHost = Microsoft.AspNetCore.WebHost.CreateDefaultBuilder().UseStartup<Startup>().Build();
            Assert.IsNotNull(webHost);
        }


    }
}
