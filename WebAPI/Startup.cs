using Business.Abstract;
using Business.Adapters.Abstract;
using Business.Adapters.Concrete;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI
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

            services.AddSingleton<IMailService, MailService>();

            services.AddCors();
            services.AddControllers();
            services.AddSingleton<IUserService,UserManager>();
            services.AddSingleton<IUserDal, EfUserDal>();

            services.AddSingleton<ICityService, CityManager>();
            services.AddSingleton<ICityDal, EfCityDal>();

            services.AddSingleton<IFieldService, FieldManager>();
            services.AddSingleton<IFieldDal, EfFieldDal>();

            services.AddSingleton<ILeagueService, LeagueManager>();
            services.AddSingleton<ILeagueDal, EfLeagueDal>();

            services.AddSingleton<ITeamService, TeamManager>();
            services.AddSingleton<ITeamDal, EfTeamDal>();

            services.AddSingleton<IQuestionService, QuestionManager>();
            services.AddSingleton<IQuestionDal, EfQuestionDal>();

            services.AddSingleton<IInqueryService, InqueryManager>();
            services.AddSingleton<IInqueryDal, EfInqueryDal>();

            services.AddSingleton<IProductService, ProductManager>();
            services.AddSingleton<IProductDal, EfProductDal>();

            services.AddSingleton<ICreditCardService, CreditCardManager>();
            services.AddSingleton<ICreditCardDal, EfCreditCardDal>();

            services.AddSingleton<ISusbcribeService, SusbcribeManager>();
            services.AddSingleton<ISusbcribeDal, EfSusbcribeDal>();



            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "WebAPI", Version = "v1" });
            });
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebAPI v1"));
            }
            app.UseCors(builder => builder.WithOrigins("http://localhost:4200").AllowAnyHeader());
            

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
