﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(ITEKISI_API.Startup))]

namespace ITEKISI_API
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
