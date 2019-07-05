using System.ComponentModel.DataAnnotations;
using ScheduleSystem.Domain.Entities;

namespace ScheduleSystem.DataApi.Controllers.Teacher.ViewModels
{
	public class TeacherViewModel
	{
		[Required]
		[StringLength(50, MinimumLength = 3, ErrorMessage = "Name must consist from 3 to 50 chars")]
		public string Name { get; set; }

		[Required]
		[StringLength(50, MinimumLength = 3, ErrorMessage = "Surname must consist from 3 to 50 chars")]
		public string Surname { get; set; }

		public ScienceDegree ScienceDegree { get; set; }
	}
}