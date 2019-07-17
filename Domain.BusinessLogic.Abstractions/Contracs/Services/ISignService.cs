using System.Threading.Tasks;
using ScheduleSystem.Domain.BusinessLogic.Abstractions.Models.Services.Sign;

namespace ScheduleSystem.Domain.BusinessLogic.Abstractions.Contracs.Services
{
	public interface ISignService
	{
		Task SignUpAsync(SignUpModel signUpModel);
	}
}