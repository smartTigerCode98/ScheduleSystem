using System;
using System.ComponentModel.DataAnnotations;
using ScheduleSystem.Domain.Entities;

namespace ScheduleSystem.DataApi.Controllers.Schedule.ViewModels
{
	public class ScheduleViewModel
	{
		[Required]
		public Discipline Discipline { get; set; }

		[Required]
		public TypeOfOccupation TypeOfOccupation { get; set; }

		[Required]
		public Domain.Entities.Teacher Teacher { get; set; }

		[Required]
		public LectureHall LectureHall { get; set; }

		[Required]
		public DateTime Date { get; set; }
	}
}