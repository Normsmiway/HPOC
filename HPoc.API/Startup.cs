using App.Applications;
using App.Applications.UseCases.Deactivate;
using App.Applications.UseCases.FundWallets;
using App.Applications.UseCases.GetUsers;
using App.Applications.UseCases.GetWallets;
using App.Applications.UseCases.Registers;
using App.Applications.UseCases.Transfer;
using App.Applications.UseCases.Withdrawal;
using App.Applications.WalletNumbers;
using App.Domains;
using App.Infrastructure.InMemoryStore;
using HPoc.API.App.Applications.Contracts;
using HPoc.API.App.Infrastructure.Repositories;
using HPoc.API.Filters;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace HPoc.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });

            services.AddMvc(options =>
            {
                options.Filters.Add(typeof(DomainExceptionFilter));
                options.Filters.Add(typeof(ValidateModelAttribute));
            });

            services.AddSingleton<IUserRepository, UserRepository>();
            services.AddSingleton<IWalletRepository, WalletRepository>();

            services.AddScoped<UserInMemoryStore>();
            services.AddScoped<WalletInMemoryStore>();


            services.AddSingleton(c => { return new Context(); });

            services.AddSingleton<IUserStore,UserInMemoryStore>();
            services.AddSingleton<IWalletStore,WalletInMemoryStore>();
            services.AddSingleton<WalletNumberContext>();
            services.AddSingleton(typeof(InMemoryRepository<,>));

            services.AddScoped<IRegister, Register>();
            services.AddTransient<IFundWallet, FundWallet>();
            services.AddTransient<IFundTransfer, FundTransfer>();
            services.AddTransient<IDeactivateAccount, DeactivateAccount>();
            services.AddTransient<IWithdrawal, Withdrawal>();
            services.AddScoped<IUserQueries, UserQueries>();
            services.AddScoped<IWalletQueries, WalletQueries>();
            services.AddSingleton<IWalletNumberHandler, WalletNumberHandler>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Pay POC API", Version = "v1" });
            });
            services.AddApplicationInsightsTelemetry();


        }

       
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "HPoc.API v1"));
            }
            else
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("../swagger/v1/swagger.json", "HPoc.API v1"));
            }

            app.UseHttpsRedirection();
            app.UseCors("CorsPolicy");
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
