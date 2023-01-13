using Microsoft.EntityFrameworkCore;
using HotelBooks_API.Data;
using HotelBooks_API.Models;

namespace HotelBooks_API.Data
{
    public class ApiContext : DbContext
    {
        public DbSet<HotelBooking> Bookings { get; set; }

        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {
            
        }
    }
}