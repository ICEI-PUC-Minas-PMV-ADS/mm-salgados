using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using MMSalgados.WebUI.Identity.Hasher;
using MMSalgados.WebUI.Identity.Stores;
using MMSalgados.WebUI.Identity;
using AutoMapper;

namespace MMSalgados.WebUI.WebUIDependencys
{
    public static class DependencyInjection
    {
        public static void IncludeWebUIDependencys(this IServiceCollection services)
        {
            services
               .AddIdentity<ApplicationUser, ApplicationRole>()
               .AddRoles<ApplicationRole>()
               .AddDefaultTokenProviders();

            services.AddRazorPages();

            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new DomainToViewModelMappingProfile());
            });

            services.AddSingleton(mapperConfig.CreateMapper());
            services.AddTransient<IUserStore<ApplicationUser>, UserStore>();
            services.AddTransient<IRoleStore<ApplicationRole>, RoleStore>();
            services.AddScoped<IPasswordHasher<ApplicationUser>, NoPasswordHasher>();
        }
    }
}
