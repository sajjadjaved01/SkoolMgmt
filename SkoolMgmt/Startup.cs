using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Owin;
using SkoolMgmt.Models;
using System;
using System.Threading.Tasks;

[assembly: OwinStartupAttribute(typeof(SkoolMgmt.Startup))]
namespace SkoolMgmt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
