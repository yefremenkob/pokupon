using FluentValidation;
using FluentValidation.Results;

namespace Pokupon.Helpers;

public class StringValidator
{
	public ValidationResult Validate(string value, int min, int max)
	{
		IValidator<string> validator = new Validator(min, max);
		return validator.Validate(value);
	}

	private class Validator : AbstractValidator<string>
	{
		public Validator(int min, int max)
		{
			RuleFor(str => str).NotEmpty().Length(min, max);
		}
	}
}