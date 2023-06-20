using FluentValidation;
using Pokupon.Models;

namespace PokuponTests;

[TestFixture]
    public class UserTests
    {
        [Test]
        public void User_Name_ShouldBeRequired()
        {
            var user = new User("", "test@example.com", "password");
            var validator = new InlineValidator<User>();
            validator.RuleFor(u => u.Name).NotEmpty();

            var result = validator.Validate(user);

            Assert.IsFalse(result.IsValid);
            Assert.That(result.Errors.Count, Is.EqualTo(1));
            Assert.That(result.Errors[0].ErrorMessage, Is.EqualTo("'Name' must not be empty."));
        }

        [Test]
        public void User_Email_ShouldBeRequired()
        {
            var user = new User("John Doe", "", "password");
            var validator = new InlineValidator<User>();
            validator.RuleFor(u => u.Email).NotEmpty();

            var result = validator.Validate(user);

            Assert.IsFalse(result.IsValid);
            Assert.That(result.Errors.Count, Is.EqualTo(1));
            Assert.That(result.Errors[0].ErrorMessage, Is.EqualTo("'Email' must not be empty."));
        }

        [Test]
        public void User_Email_ShouldBeValidEmailAddress()
        {
            var user = new User("John Doe", "invalidemail", "password");
            var validator = new InlineValidator<User>();
            validator.RuleFor(u => u.Email).NotEmpty().EmailAddress();

            var result = validator.Validate(user);

            Assert.IsFalse(result.IsValid);
            Assert.That(result.Errors.Count, Is.EqualTo(1));
            Assert.That(result.Errors[0].ErrorMessage, Is.EqualTo("'Email' is not a valid email address."));
        }

        [Test]
        public void User_Password_ShouldBeRequired()
        {
            var user = new User("John Doe", "test@example.com", "");
            var validator = new InlineValidator<User>();
            validator.RuleFor(u => u.Password).NotEmpty();

            var result = validator.Validate(user);

            Assert.IsFalse(result.IsValid);
            Assert.That(result.Errors.Count, Is.EqualTo(1));
            Assert.That(result.Errors[0].ErrorMessage, Is.EqualTo("'Password' must not be empty."));
        }
    }