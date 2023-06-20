using System.ComponentModel.DataAnnotations;

namespace Pokupon.Models;
public class Deal
{
	[Key]
	public int Id { get; set; }
	[Required]
	public string Title { get; set; }
	[Required]
	public string Description { get; set; }
	[Required]
	[Range(1, 100)]
	public int Discount { get; set; }

	public Deal(string title, string description, int discount)
	{
		Title = title;
		Description = description;
		Discount = discount;
	}
}
