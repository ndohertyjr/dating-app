using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public interface IDataContext : IDisposable
{
    DbSet<AppUser> Users { get; set; }
}