using Egz.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Egz.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static void ApplyDbMigrations(this IApplicationBuilder applicationBuilder)
        {
            using var serviceScope = applicationBuilder.ApplicationServices.CreateScope();

            var eAppointmentDbContext = serviceScope
                .ServiceProvider
                .GetService<EgzDbContext>();
            // ReSharper disable once PossibleNullReferenceException
            eAppointmentDbContext.Database.Migrate();
        }
    }
}