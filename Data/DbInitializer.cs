using Assignment4_Elections.Models;
using System;
using System.Linq;

namespace Assignment4_Elections.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ElectionContext context)
        {
            context.Database.EnsureCreated();

        }
    }
}
