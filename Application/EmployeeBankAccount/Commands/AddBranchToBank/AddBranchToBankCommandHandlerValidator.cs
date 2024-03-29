﻿using FluentValidation;

namespace Application.EmployeeBankAccount.Commands.AddBranchToBank
{
    public class AddBranchToBankCommandHandlerValidator : AbstractValidator<AddBranchToBankCommand>
    {
        public AddBranchToBankCommandHandlerValidator()
        {
            RuleFor(x => x.branch).NotNull();
            RuleFor(x => x.branch.BankId).NotEmpty();
            RuleFor(x => x.branch.Name).NotEmpty();
        }
    
    }


}
