using CodingChallenge.Classroom.Application.Context;
using CodingChallenge.Classroom.Domain.Models;
using Microsoft.Extensions.Logging;

namespace CodingChallenge.Classroom.Infrastructure.Repositories;

public class ClassroomRepository(ILogger<ReadOnlyClassroomRepository> logger, IClassroomDbContext dbContext) : IClassroomRepository
{
    public async Task SaveAsync(StudentProgress obj, CancellationToken cancellationToken = default)
    {
        await dbContext.StudentProgress.AddAsync(obj, cancellationToken);
        await dbContext.SaveChangesAsync(cancellationToken);
    }
}