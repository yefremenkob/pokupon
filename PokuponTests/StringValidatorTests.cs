using Pokupon.Helpers;

namespace PokuponTests;

public class StringValidatorTests
{
	private readonly StringValidator _stringValidator = new();
	
	[Test]
	public void ValidateTest1()
	{
		Assert.That(_stringValidator.Validate("123", 1, 3).IsValid, Is.True);
	}
	
	[Test]
	public void ValidateTest2()
	{
		Assert.That(_stringValidator.Validate("123", 1, 3).IsValid, Is.True);
	}
	
	[Test]
	public void ValidateTest3()
	{
		Assert.That(_stringValidator.Validate("dsfgdsgsfdg", 5, 20).IsValid, Is.True);
	}
	
	[Test]
	public void ValidateTest4()
	{
		Assert.Throws<ArgumentOutOfRangeException>(() =>
		{
			_stringValidator.Validate("123", 10, 3);
		});
	}
	
	[Test]
	public void ValidateTest5()
	{
		Assert.That(_stringValidator.Validate("121212341241", 1, 3).IsValid, Is.False);
	}
	
	[Test]
	public void ValidateTest6()
	{
		Assert.That(_stringValidator.Validate("1212", 5, 10).IsValid, Is.False);
	}

	[Test]
	public void ValidateTest7()
	{
		Assert.Throws<ArgumentOutOfRangeException>(() =>
		{
			_stringValidator.Validate("1212", 5, -10);
		});
	}
	
	[Test]
	public void ValidateTest8()
	{
		Assert.That(_stringValidator.Validate("tes", -50, 10).IsValid, Is.True);
	}
}