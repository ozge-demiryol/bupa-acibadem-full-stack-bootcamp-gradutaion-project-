using InsuranceSystem.Bll.Base;
using InsuranceSystem.Bll.Manager;
using InsuranceSystem.Dal.Abstract;
using InsuranceSystem.Dal.Abstract.AbstractRepositories;
using InsuranceSystem.Dal.Concrete.EntityFramework.Repository;
using InsuranceSystem.Dal.Concrete.EntityFramework.UnitOfWork;
using InsuranceSystem.Entity.Models;
using InsuranceSystem.Interface.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsuranceSystem
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
            //Db baglantisi
            #region ApplicationContext
            services.AddScoped<DbContext, Health_Insurance_DbContext>();
            services.AddDbContext<Health_Insurance_DbContext>(opt =>
            {
                opt.UseSqlServer(Configuration.GetConnectionString("SqlServer"), sqlOpt =>
                {
                    sqlOpt.MigrationsAssembly("InsuranceSystem.Dal");
                });
            });

            #endregion

            //Dependency Injection

            #region UnitOfWork
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            #endregion

            #region Repositories
            services.AddScoped<ICityRepository, CityRepository>();
            services.AddScoped<ICreditCardRepository,CreditCardRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IOrderDetailRepository, OrderDetailRepository>();
            services.AddScoped<IOrderStatusRepository, OrderStatusRepository>();
            services.AddScoped<IPaymentTypeRepository, PaymentTypeRepository>();
            services.AddScoped<IPolicyRepository, PolicyRepository>();
            services.AddScoped<IRegionRepository, RegionRepository>();
            services.AddScoped<IApplicationRepository, ApplicationRepository>();
            services.AddScoped<IOrdersCustomerRepository, OrdersCustomerRepository>();
            #endregion

            #region Services
            services.AddScoped<ICityService,CityManager>();
            services.AddScoped<ICreditCardService, CreditCardManager>();
            services.AddScoped<ICustomerService, CustomerManager>();
            services.AddScoped<IOrderService, OrderManager>();
            services.AddScoped<IOrderDetailService, OrderDetailManager>();
            services.AddScoped<IOrderStatusService, OrderStatusManager>();
            services.AddScoped<IPaymentTypeService, PaymentTypeManager>();
            services.AddScoped<IPolicyService, PolicyManager>();
            services.AddScoped<IRegionService, RegionManager>();
            services.AddScoped<IApplicationService, ApplicationManager>();
            services.AddScoped<IOrdersCustomerService, OrdersCustomerManager>();
            #endregion

            #region Cors Settings
            services.AddCors(opt =>
            {
                opt.AddPolicy("CorsPlicy",
                    builder => builder
                    .AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                );
            });
            #endregion

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "InsuranceSystem", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "InsuranceSystem v1"));
            }

            app.UseCors(builder => builder.AllowAnyOrigin().AllowAnyMethod());
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
