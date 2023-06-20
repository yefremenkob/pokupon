using FluentValidation;
using FluentValidation.Results;

namespace Pokupon.Helpers;

public class StringValidator : AbstractValidator<string>
{
	public ValidationResult Validate(string value, int min, int max)
	{
		RuleFor(str => str).NotEmpty().Length(min, max);
		return Validate(value);
	}
}