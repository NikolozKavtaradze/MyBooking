using Microsoft.EntityFrameworkCore;
using MyBooking.Domain.Abstractions;

namespace MyBooking.Infrastructure;

public sealed class ApplicationDbContext : DbContext, IUnitOfWork
{
    public ApplicationDbContext(DbContextOptions options)
        : base(options)
    {

    }
}