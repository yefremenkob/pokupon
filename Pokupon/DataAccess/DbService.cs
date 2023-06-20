using Pokupon.Models;

namespace Pokupon.DataAccess;

public sealed class DbService : IDbService
{
	private readonly DatabaseContext _db;
	
	public DbService()
	{
		_db = new DatabaseContext();
	}
	
	public DbService(DatabaseContext db)
	{
		_db = db;
	}
	
	public List<Deal> GetDeals()
	{
		return _db.Deals.ToList();
	}

	public void InsertDeal(Deal deal)
	{
		_db.Deals.Add(deal);
	}

	public void DeleteDeal(Deal deal)
	{
		_db.Deals.Remove(deal);
	}

	public List<User> GetUsers()
	{
		return _db.Users.ToList();
	}

	public void InsertUser(User user)
	{
		_db.Users.Add(user);
	}

	public void DeleteUser(User user)
	{
		_db.Users.Remove(user);
	}
	public List<Deal> SearchDeals(string searchTerm, string searchBy)
	{
		switch (searchBy)
		{
			case "SearchByTitleTextBox":
				return _db.Deals.ToList().Where(deal => deal.Title.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

			case "SearchByDescriptionTextBox":
				return _db.Deals.ToList().Where(deal => deal.Description.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

			case "SearchByDiscountTextBox":
				return _db.Deals.ToList().Where(deal => deal.Discount.ToString().Contains(searchTerm)).ToList();

			default:
				throw new ApplicationException();
		}
	}

	public void SaveChanges()
	{
		_db.SaveChanges();
	}

	private bool _disposed = false;

	private void Dispose(bool disposing)
	{
		if (!this._disposed)
		{
			if (disposing)
			{
				_db.Dispose();
			}
		}
		this._disposed = true;
	}
	
	public void Dispose()
	{
		Dispose(true);
		GC.SuppressFinalize(this);
	}
}