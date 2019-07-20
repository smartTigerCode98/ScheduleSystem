namespace ScheduleSystem.Domain.BusinessLogic.Abstractions.Contracs.Services
{
	public interface IPasswordHasher
	{
		string Hash(string password);

		bool Verify(string passwordHash, string givenPassword);
	}
}