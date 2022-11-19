using ApiProyecto.Context;
using Microsoft.EntityFrameworkCore;


namespace ApiProyecto
{
    public class Startup
    {
        public IConfiguration Configuration { get; }  

        public Startup (IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("Conexion")));
        }

        public void Configure(IApplicationBuilder app, IHostApplicationLifetime lifetime)
        {

        }
    }
}
