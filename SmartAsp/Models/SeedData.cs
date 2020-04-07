using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SmartAsp.Data;
using System;
using System.Linq;

namespace SmartAsp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SmartAspContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<SmartAspContext>>()))
            {
                // Look for any movies.
                if (context.Product.Any())
                {
                    return;   // DB has been seeded
                }

                
            }
        }
    }
}