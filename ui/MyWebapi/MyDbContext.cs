
using Microsoft.EntityFrameworkCore;

namespace MyWebapi {

    public class MyDbContext : DbContext{

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }



    }



}