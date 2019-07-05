using System;
using System.ComponentModel.DataAnnotations;
using ScheduleSystem.Domain.BusinessLayer.Entities;

namespace ScheduleSystem.DataApi.Controllers.ModelView
{
	public class ScheduleModel
	{
		[Required]
		public Discipline Discipline { get; set; }

		[Required]
		public TypeOfOccupation TypeOfOccupation { get; set; }

		[Required]
		public Teacher Teacher { get; set; }

		[Required]
		public LectureHall LectureHall { get; set; }

		[Required]
		public DateTime Date { get; set; }
	}
}