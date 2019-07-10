using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using ScheduleSystem.DataSource.Abstractions.Contracts;
using ScheduleSystem.Domain.Entities;

namespace ScheduleSystem.DataSource.Implementation.MockDataSource
{
    public class LectureHallRepository : ILectureHallRepository
    {
        private readonly ICollection<LectureHall> _lectureHalls = new Collection<LectureHall>
        {
            new LectureHall(1, "404"),
            new LectureHall(2, "102a"),
            new LectureHall(3, "1b")
        };
        public Task<LectureHall> GetByIdAsync(int id)
        {
            return Task.FromResult(_lectureHalls.FirstOrDefault(lh => lh.Id == id));
        }

        public Task<ICollection<LectureHall>> GetAllAsync()
        {
            return Task.FromResult(_lectureHalls);
        }

        public Task CreateAsync(LectureHall entities)
        {
            return Task.FromResult<>(_lectureHalls.Add(entities));
        }

        public Task UpdateAsync(LectureHall entities)
        {
            var necessaryLectureHall = _lectureHalls.First(lh => lh.Id == entities.Id);
            necessaryLectureHall.Number = entities.Number;
            return Task.FromResult(necessaryLectureHall);
        }

        public Task DeleteAsync(LectureHall entities)
        {
            return Task.FromResult(_lectureHalls.Remove(entities));
        }

        public Task SaveChangesAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}