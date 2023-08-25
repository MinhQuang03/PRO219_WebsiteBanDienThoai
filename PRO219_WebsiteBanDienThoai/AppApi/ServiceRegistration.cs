using AppData.IRepositories;
using AppData.Repositories;

namespace AppApi
{
    public static class ServiceRegistration
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddScoped<IAccountStaffRepository, AccountStaffRepository>();
            services.AddScoped<ISimRepository, SimRepository>();
        }
    }
}
