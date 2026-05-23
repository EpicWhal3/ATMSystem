using Application.AdminServices;
using Application.Contracts.Admin;
using Application.Contracts.User;
using Application.UserServices;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Extensions;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddApplication(this IServiceCollection collection)
    {
        collection.AddScoped<IUserLoginService, UserLoginService>();
        collection.AddScoped<IAdminLoginService, AdminLoginService>();
        collection.AddScoped<UserService>();
        collection.AddScoped<IUserServices>(
            p => p.GetRequiredService<UserService>());

        return collection;
    }
}