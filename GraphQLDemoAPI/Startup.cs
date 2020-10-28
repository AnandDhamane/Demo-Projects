using GraphiQl;
using GraphQL;
using GraphQL.Types;
using GraphQLDemoAPI.Infrastructure.DBContext;
using GraphQLDemoAPI.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace GraphQLDemoAPI {
    public class Startup {
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) {
            services.AddControllers();

            services.AddDbContext<GraphQLDemoContext>
                (options => options.UseSqlServer(Configuration.GetConnectionString("GraphQLDBConnection")));

            services.AddTransient<ITechEventRepository, TechEventRepository>();

            services.AddSingleton<TechEventInfoType>();
            services.AddSingleton<ParticipantType>();
            services.AddSingleton<TechEventQuery>();
            var sp = services.BuildServiceProvider();
            services.AddSingleton<ISchema>(new TechEventSchema(new  FuncDependencyResolver(type => sp.GetService(type))));

            services.AddSingleton<IDocumentExecuter, DocumentExecuter>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseGraphiQl("/graphql");

            app.UseEndpoints(endpoints => {
                endpoints.MapControllers();
            });
        }
    }
}
