using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ScheduleSystem.Domain.Entities;

namespace ScheduleSystem.DataSource.Abstractions.Contracts.DBContext
{
    public interface IDatabaseContext 
    {
        DbSet<User>        Users        { get; set; }
        DbSet<Discipline>  Disciplines  { get; set; }
        DbSet<LectureHall> LectureHalls { get; set; }
        DbSet<ScienceDegree> ScienceDegrees { get; set; }
        DbSet<Teacher> Teachers { get; set; }
        DbSet<TypeOfOccupation> TypeOfOccupations { get; set; }
        DbSet<Schedule> Schedules { get; set; }
        Task<int> SaveChangesAsync(CancellationToken ctoken = default);
    }
}