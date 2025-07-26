using Celestia.BLL.Dtos.UserDto;
using FluentValidation;
using System.Text.RegularExpressions;

namespace Celestia.BLL.Validators
{
    public class UserCreateDtoValidator : AbstractValidator<UserCreateDto>
    {
        public UserCreateDtoValidator()
        {
            RuleFor(u => u.FirstName).NotEmpty().WithMessage("Firstname must not be empty").MaximumLength(50).WithMessage("Length must be less than 50");


            RuleFor(u => u.LastName).MaximumLength(50).WithMessage("Length must be less than 50");

            RuleFor(u => u.Email).NotEmpty().WithMessage("Email must not be empty").Must(EmailCheck).WithMessage("Email is invalid");

            RuleFor(u => u.Password).NotEmpty().WithMessage("Password must not be empty").Must(PasswordCheck).WithMessage("Password is invalid");

            RuleFor(u => u.UserName).NotEmpty().WithMessage("UserName must not be empty").Must(UserNameCheck).WithMessage("UserName is invalid");


        }

        private bool  EmailCheck(string email)
        {
            var pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return  Regex.IsMatch(email, pattern);

        }
        private bool PasswordCheck(string password)
        {
            var pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@#$%^&+=!]).{8,}$";

            return  Regex.IsMatch(password, pattern);

           
        }
        private bool UserNameCheck(string userName)
        {
            var pattern = @"^[a-zA-Z0-9_]{3,20}$";

            return Regex.IsMatch(userName, pattern);

        
        }
    }
}
