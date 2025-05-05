using libraryAPI.Authentication;
using libraryAPI.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace libraryAPI
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDependencies(this IServiceCollection services,IConfiguration configuration)
        {

            services.AddScoped<IAuthService, AuthService>();

            services.AddAuthConfig(configuration);


            return services;
        }

        private static IServiceCollection AddAuthConfig(this IServiceCollection services,IConfiguration configuration)
        {

            services.AddOptions<JWTSettings>()
                .BindConfiguration(JWTSettings.SectionName)
                .ValidateDataAnnotations()
                .ValidateOnStart();

            var jwtSetting = configuration.GetSection(JWTSettings.SectionName).Get<JWTSettings>();
            services.AddAuthentication(option =>
            {
                option.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                option.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(option =>
            {
                option.TokenValidationParameters = new TokenValidationParameters
                {

                    ValidateIssuer = true,
                    ValidateAudience=true ,
                    ValidateLifetime=true,
                    ValidateIssuerSigningKey=true,
                    ValidIssuer = jwtSetting?.Issuer,
                    ValidAudience = jwtSetting?.Audience,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSetting?.Key!))

                };

                
            });
            return services;
        }
    }
}
