using Microsoft.EntityFrameworkCore;
using ScheduleSystem.Domain.Entities;

namespace ScheduleSystem.DataSource.Abstractions.Contracts.DBContext
{
    public interface IReadOnlyDatabaseContext
    {
        DbSet<User>        Users        { get; set; }
        DbSet<Discipline>  Disciplines  { get; set; }
        DbSet<LectureHall> LectureHalls { get; set; }
        DbSet<ScienceDegree> ScienceDegrees { get; set; }
        DbSet<Teacher> Teachers { get; set; }
        DbSet<TypeOfOccupation> TypeOfOccupations { get; set; }
        DbSet<Schedule> Schedules { get; set; }
    }
}