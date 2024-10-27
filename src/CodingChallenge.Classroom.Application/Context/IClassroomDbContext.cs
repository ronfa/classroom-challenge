using CodingChallenge.Classroom.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace CodingChallenge.Classroom.Application.Context;

public interface IClassroomDbContext
{
    DbSet<StudentProgress> StudentProgress { get; set; }
    
    DatabaseFacade Database { get; }
    
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}