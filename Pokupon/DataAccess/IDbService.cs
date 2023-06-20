using Pokupon.Models;

namespace Pokupon.DataAccess;

public interface IDbService
{
	List<Deal> GetDeals();
	void InsertDeal(Deal deal);
	void DeleteDeal(Deal deal);
	List<Deal> SearchDeals(string searchTerm, string searchBy);
	List<User> GetUsers();
	void InsertUser(User user);
	void DeleteUser(User user);

	void SaveChanges();
}