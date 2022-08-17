using BackEnd.Model;
using Microsoft.EntityFrameworkCore;

namespace BackEnd
{
    public class RTAppDatabase : DbContext
    {
        public DbSet<Seat> Seats { get; set; }
    }
}