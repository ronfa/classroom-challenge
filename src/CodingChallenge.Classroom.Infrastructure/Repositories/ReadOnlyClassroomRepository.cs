using CodingChallenge.Classroom.Application.Context;
using CodingChallenge.Classroom.Infrastructure.Repositories.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace CodingChallenge.Classroom.Infrastructure.Repositories;
public class ReadOnlyClassroomRepository(ILogger<ReadOnlyClassroomRepository> logger, IClassroomDbContext dbContext)
    : IReadonlyClassroomRepository
{
    public async Task<ClassroomResponse> GetClassroomOverviewAsync(
        int classroomId, DateTime currentDate, CancellationToken cancellationToken)
    {
        var result = from student in dbContext.StudentProgress
            where student.SubmitDateTime.Date == currentDate.Date
            && student.SubmitDateTime <= currentDate
            group student by new{student.Subject, student.Domain, student.LearningObjective} 
            into g 
            select new Subject
            {
                Name = g.Key.Subject,
                Domain = g.Key.Domain,
                LearningObjective = g.Key.LearningObjective,
                Progress = g.Sum(p => p.Progress),
            };
        
        return new ViewModels.ClassroomResponse
        {
            Subjects = await result.ToListAsync(cancellationToken: cancellationToken)
        };
    }
}