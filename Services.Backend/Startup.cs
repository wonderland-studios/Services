﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Services.Backend.Startup))]
namespace Services.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
