using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using ScheduleSystem.DataSource.Abstractions.Contracts;
using ScheduleSystem.Domain.Entities;

namespace ScheduleSystem.DataSource.Implementation.MockDataSource
{
    public class DisciplineRepository : IDisciplineRepository
    {
        private readonly ICollection<Discipline> _disciplines = new Collection<Discipline>
        {
            new Discipline(1, "Math", 120),
            new Discipline(2, "Programming", 160),
            new Discipline(3, "Algorithms", 90)
            
        };
        
        public Task<Discipline> GetByIdAsync(int id)
        {
            return Task.FromResult(_disciplines.FirstOrDefault(d => d.Id == id));
        }

        public Task<ICollection<Discipline>> GetAllAsync()
        {
            return Task.FromResult(_disciplines);
        }

        public Task CreateAsync(Discipline entities)
        {
            return Task.FromResult<>(_disciplines.Add(entities));
        }

        public Task UpdateAsync(Discipline entities)
        {
            var necessaryDiscipline = _disciplines.First(d => d.Id == entities.Id);
            necessaryDiscipline.Name = entities.Name;
            necessaryDiscipline.Credits = entities.Credits;
            return Task.FromResult(necessaryDiscipline);
        }

        public Task DeleteAsync(Discipline entities)
        {
            return Task.FromResult(_disciplines.Remove(entities));
        }

        public Task SaveChangesAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}