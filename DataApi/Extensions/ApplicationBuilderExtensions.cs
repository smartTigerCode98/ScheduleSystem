using Microsoft.AspNetCore.Builder;

namespace ScheduleSystem.DataApi.Extensions
{
    internal static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseSwaggerInShortForm(this IApplicationBuilder app)
        {
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Schedule system");
            });

            return app;
        }
    }
}