using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;
using Microsoft.Azure.Mobile.Server;
using Microsoft.Azure.Mobile.Server.Swagger;
using Swashbuckle.Application;

namespace WebApplication1
{
    public partial class Startup
    {
        public static void ConfigureSwagger(HttpConfiguration config)
        {
            config.Services.Replace(typeof(IApiExplorer), new MobileAppApiExplorer(config));

            config.EnableSwagger(c =>
            {
                c.SingleApiVersion("v2", "myService");
                c.OperationFilter<MobileAppHeaderFilter>();
                c.SchemaFilter<MobileAppSchemaFilter>();
            })
            .EnableSwaggerUi();
        }
    }
}