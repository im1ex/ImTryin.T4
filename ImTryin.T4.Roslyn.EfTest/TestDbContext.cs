using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ImTryin.T4.Roslyn.EfTest
{
    public partial class TestDbContext : DbContext
    {
    }

    public abstract partial class BaseEntity
    {
        public long Id { get; set; }
    }

    public partial class Author : BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }

    public partial class Book : BaseEntity
    {
        public string Name { get; set; }

        public virtual Author Author { get; set; }
    }
}
