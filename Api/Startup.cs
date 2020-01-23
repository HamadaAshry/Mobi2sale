using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Threading.Tasks;
using Api.MiddleWare;
using Application.Admin.web.Categories;
using Application.Admin.web.Categories.Commands;
using Application.Envelopes;
using Application.Interfaces;
using Application.Interfaces.CategoryRepositories;
using Application.Interfaces.Persistence;
using AutoMapper;
using CommonHelpers;
using Domain.IdentityUsers;
//using Domain.IdentityUsers;
using FluentValidation.AspNetCore;
using Infrastructure;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Persistence;
using Persistence.Admin.Web.Repos;

namespace Api {
    public class Startup {
        public Startup (IConfiguration configuration) {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices (IServiceCollection services) {

            services.AddDbContext<DataContext> (opts => {
                opts.UseSqlServer (Configuration.GetConnectionString ("DefaultConnection").ToString ());
            });

            services.AddDefaultIdentity<AppUser>()
                    .AddEntityFrameworkStores<DataContext>();
                    // options => options.SignIn.RequireConfirmedAccount = true
            services.AddControllers ().AddJsonOptions (o => {
                    o.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
                    o.JsonSerializerOptions.WriteIndented = true;
                })
                .AddFluentValidation (cfg => cfg.RegisterValidatorsFromAssemblyContaining<Create> ());
            services.AddCors (options => {
                options.AddPolicy ("CorsPolicy", configurePolicy => {
                    configurePolicy.AllowAnyOrigin ().AllowAnyHeader ().AllowAnyOrigin ();
                });
            });

            //var builder=services.AddIdentityCore<AppUser>();
            //var identityBuilder=new IdentityBuilder(builder.UserType,builder.Services);
            //identityBuilder.AddEntityFrameworkStores<DataContext>();
            //identityBuilder.AddSignInManager<SignInManager<AppUser>>();
            
            services.AddSwaggerGen (c => {
                c.SwaggerDoc ("v1", new OpenApiInfo {
                    Title = "Mobi2sale Api",
                        Version = "v1",
                        Description = "All the Apis of Mobi2sale Web and Mobile Application",
                        TermsOfService = new Uri ("https://example.com/terms"),
                        Contact = new OpenApiContact {
                            Name = "Agorithm",
                                Email = string.Empty,
                                Url = new Uri ("http://algorithm-eg.com"),
                        },
                        License = new OpenApiLicense {
                            Name = "Use under LICX",
                                Url = new Uri ("https://example.com/license"),
                        }
                });
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine (AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments (xmlPath);

                c.CustomSchemaIds (i => i.FullName);
            });



            services.AddScoped (typeof (IGenericRepository<>), typeof (GenericRepository<>));
            services.AddScoped (typeof (IEnvelopes<>), typeof (Envelopes<>));
            services.AddScoped (typeof (IUnitOfWork), typeof (UnitOfWork));
            services.AddScoped (typeof (ICategoryRepo), typeof (CategoryRepo));
            services.AddScoped<IResponseHandler, ResponseHandler> ();
            services.AddScoped<IPaginationAndFilterProps, PaginationAndFilteringPropscs> ();
            services.AddScoped<IFileHandler, FileHandler> ();
            services.AddAutoMapper (typeof (List.Handler).Assembly);
            services.AddMediatR (typeof (List.Handler).Assembly);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure (IApplicationBuilder app, IWebHostEnvironment env) {
            app.UseMiddleware<ErrorhandlingMiddleware> ();
            if (env.IsDevelopment ()) {
                // app.UseDeveloperExceptionPage ();
            }
            app.UseSwagger ();
            app.UseSwaggerUI (c => {
                c.SwaggerEndpoint ("/swagger/v1/swagger.json", "Admin Api V1");
                c.RoutePrefix = string.Empty;
            });

            // app.UseHttpsRedirection();
            app.UseCors ("CorsPolicy");
            app.UseRouting ();
            app.UseAuthorization ();
            app.UseStaticFiles ();
            app.UseEndpoints (endpoints => {
                endpoints.MapControllers ();
            });
        }
    }
}