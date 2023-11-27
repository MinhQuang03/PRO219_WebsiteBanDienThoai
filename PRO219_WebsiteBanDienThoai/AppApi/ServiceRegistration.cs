﻿using AppData.IRepositories;
using AppData.Repositories;
using AppData.Services;
using AppData.IServices;

namespace AppApi
{
    public static class ServiceRegistration
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddTransient<IAccountsRepository, AccountsRepository>();
            services.AddTransient<ISimRepository, SimRepository>();
            services.AddTransient<IPhoneDetaildRepository, PhoneDetaildRepository>();
            services.AddTransient<IPhoneDetailService, PhoneDetailService>();
            services.AddTransient<IChargingportTypeRepository, ChargingportTypeRepository>();
            services.AddTransient<IChipCPURepository, ChipCPURepository>();
            services.AddTransient<IChipGPURepository, ChipGPURepository>();
            services.AddTransient<IColorRepository, ColorRepository>();
            services.AddTransient<IPhoneRepository, PhoneRepository>();
            services.AddTransient<IProductionCompanyRepository, ProductionCompanyRepository>();
            services.AddTransient<IBlogRepository,BlogRepository>();
            services.AddTransient<IBlogDetailRepository, BlogDetailRepository>();
            services.AddTransient<IBatteryRepository, BatteryRepository>();
            services.AddTransient<IMaterialRepository, MaterialRepository>();
            services.AddTransient<IOpertingRepository, OperatingRepository>();
            services.AddTransient<IRamRepository, RamRepository>();
            services.AddTransient<IRomRepository, RomRepository>();
            services.AddTransient<ISimRepository, SimRepository>();
            services.AddTransient<IImeiRepository, ImeiRepository>();
            services.AddTransient<IUserRepository, UserRepostitory>();
            services.AddTransient<IAddressRepository, AddressRepostitory>();
        }
    }
}
