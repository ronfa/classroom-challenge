using CodingChallenge.Classroom.Domain.Models;

namespace CodingChallenge.Classroom.Infrastructure.Repositories;

public interface IClassroomRepository
{
    Task SaveAsync(StudentProgress obj, CancellationToken cancellationToken = default);
}