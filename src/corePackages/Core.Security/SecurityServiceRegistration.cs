﻿using Core.Security.EmailAuthenticator;
using Core.Security.GoogleAuth;
using Core.Security.JWT;
using Core.Security.MicrosoftAuth;
using Core.Security.OtpAuthenticator;
using Core.Security.OtpAuthenticator.OtpNet;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class SecurityServiceRegistration
{
    public static IServiceCollection AddSecurityServices(this IServiceCollection services)
    {
        services.AddScoped<ITokenHelper, JwtHelper>();
        services.AddScoped<IEmailAuthenticatorHelper, EmailAuthenticatorHelper>();
        services.AddScoped<IOtpAuthenticatorHelper, OtpNetOtpAuthenticatorHelper>();
        services.AddScoped<IMicrosoftAuthAdapter, MicrosoftAuthAdapter>();
        services.AddScoped<IGoogleAuthAdapter, GoogleAuthAdapter>();
        return services;
    }
}