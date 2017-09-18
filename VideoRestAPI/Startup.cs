using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using VideoMenuBLL;
using VideoMenuBLL.BusinessObjects;

namespace VideoRestAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                var facade = new BLLFacade();

                var actionGenre = facade.GenreService.Create(
                    new GenreBO()
                    {
                        Name = "Action"
                    });
                var advGenre = facade.GenreService.Create(
                    new GenreBO()
                    {
                        Name = "Adventure"
                    });
                var comedyGenre = facade.GenreService.Create(
                    new GenreBO()
                    {
                        Name = "Comedy"
                    });


                facade.VideoService.Create(
                    new VideoBO()
                    {
                        Name = "Avengers"
                    });
                facade.VideoService.Create(
                    new VideoBO()
                    {
                        Name = "Iron Man"
                    });
                facade.VideoService.Create(
                    new VideoBO()
                    {
                        Name = "Thor",
                        GenreId = actionGenre.Id
                    });


               
            }

            app.UseMvc();
        }
    }
}
