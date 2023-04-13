using ICI.ProvaCandidato.Dados.DependenciesExtension;
using ICI.ProvaCandidato.Dados.Repository.Interface;
using ICI.ProvaCandidato.Dados.Repository;
using ICI.ProvaCandidato.Negocio.Service.Interface;
using ICI.ProvaCandidato.Negocio.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ICI.ProvaCandidato.Dados.Data;
using ICI.ProvaCandidato.Web.Models;
using ICI.ProvaCandidato.Web.Models.Interface;
using ICI.ProvaCandidato.Dados.Entities;
using ICI.ProvaCandidato.Web.AutoMapper.DTO;
using System.Reflection;

namespace ICI.ProvaCandidato.Web
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
			services.AddControllersWithViews();
            services.AddDbContext<AppDbContext>();
            services.AddScoped<ITagRepositorio, TagRepositorio>();
            services.AddScoped<INoticiaRepositorio, NoticiaRepositorio>();
            services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();
            services.AddScoped<ITagService, TagService>();
            services.AddScoped<INoticiaService, NoticiaService>();
            services.AddScoped<IUsuarioService, UsuarioService>();
            services.AddScoped<ITagModel, TagModel>();
            services.AddScoped<INoticiaModel, NoticiaModel>();
            services.AddScoped<IUsuarioModel, UsuarioModel>();
            services.AddAutoMapper(dto =>
            {
                dto.CreateMap<TagDTO, Tag>();
				dto.CreateMap<NoticiaDTO, Noticia>();
                dto.CreateMap<UsuarioDTO, Usuario>();
            }, Assembly.GetExecutingAssembly());
        }

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			app.UseDeveloperExceptionPage();

			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(
									name: "default",
									pattern: "{controller=Home}/{action=Index}/{id?}");
			});
		}
	}
}
