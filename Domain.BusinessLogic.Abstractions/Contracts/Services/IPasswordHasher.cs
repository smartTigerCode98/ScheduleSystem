namespace ScheduleSystem.Domain.BusinessLogic.Abstractions.Contracts.Services
{
	public interface IPasswordHasher
	{
		string Hash(string password);

		bool Verify(string passwordHash, string givenPassword);
	}
}