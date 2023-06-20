using System.ComponentModel.DataAnnotations;
using FluentValidation;
using Pokupon.Models;

namespace PokuponTests;

[TestFixture]
public class DealTests
{
	[Test]
	public void Deal_Title_ShouldBeRequired()
	{
		var deal = new Deal("", "Description", 10);

		var context = new ValidationContext(deal, serviceProvider: null, items: null);
		var results = new List<ValidationResult>();

		bool isValid = Validator.TryValidateObject(deal, context, results, validateAllProperties: true);

		Assert.IsFalse(isValid);
		Assert.That(results.Count, Is.EqualTo(1));
		Assert.That(results[0].ErrorMessage, Is.EqualTo("The Title field is required."));
	}

	[Test]
	public void Deal_Description_ShouldBeRequired()
	{
		var deal = new Deal("Title", "", 10);

		var context = new ValidationContext(deal, serviceProvider: null, items: null);
		var results = new List<ValidationResult>();

		bool isValid = Validator.TryValidateObject(deal, context, results, validateAllProperties: true);

		Assert.IsFalse(isValid);
		Assert.That(results.Count, Is.EqualTo(1));
		Assert.That(results[0].ErrorMessage, Is.EqualTo("The Description field is required."));
	}

	[Test]
	public void Deal_Discount_ShouldBeInRange()
	{
		var deal = new Deal("Title", "Description", 150);

		var context = new ValidationContext(deal, serviceProvider: null, items: null);
		var results = new List<ValidationResult>();

		bool isValid = Validator.TryValidateObject(deal, context, results, validateAllProperties: true);

		Assert.IsFalse(isValid);
		Assert.That(results.Count, Is.EqualTo(1));
		Assert.That(results[0].ErrorMessage, Is.EqualTo("The field Discount must be between 1 and 100."));
	}
}