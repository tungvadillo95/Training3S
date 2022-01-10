using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDExample.Domain.Infrastructure.Handler.User.Commands.CreateUser
{
    public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
    {
        public CreateUserCommandValidator()
        {
            RuleFor(x => x.UserName)
                .NotNull().WithMessage("Chưa nhập Tên đăng nhập")
                .NotEmpty().WithMessage("Chưa nhập Tên đăng nhập")
                .MaximumLength(50).WithMessage("Tên đăng nhập vượt quá 50 ký tự");
            RuleFor(x => x.FullName)
                .NotNull().WithMessage("Chưa nhập Họ tên")
                .NotEmpty().WithMessage("Chưa nhập Họ tên")
                .MaximumLength(50).WithMessage("Họ tên vượt quá 50 ký tự");
            RuleFor(x => x.Password)
                .NotNull().WithMessage("Chưa nhập Mật khẩu")
                .NotEmpty().WithMessage("Chưa nhập Mật khẩu")
                .MaximumLength(20).WithMessage("Mật khẩu vượt quá 20 ký tự");
            RuleFor(x => x.RoleId)
                .NotNull().WithMessage("Chưa chọn Vai trò")
                .NotEmpty().WithMessage("Chưa chọn Vai trò");
        }
    }
}
