using Application.Common;
using Application.EmployeeGrades.Query.GetEmployeeCurrentGrade;
using Application.Interfaces;
using Domain.Constant;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.EmployeeGrades.Commands.AssignEmployeeToGrade
{
    public record AssignEmployeeToGradeCommand(int employeeId,int gradeId,DateTime assignDate):IRequest<Result< Unit>>;
    public partial class AssignEmployeeToGradeCommandHandler : Handler<AssignEmployeeToGradeCommand, Result<Unit>>
    {
        public AssignEmployeeToGradeCommandHandler(IUOW uow) : base(uow)
        {
        }

        public override async Task<Result<Unit>> Handle(AssignEmployeeToGradeCommand request, CancellationToken cancellationToken)
        {
            var validation = new AssignEmployeeToGradeCommandValidator();
            var validate = await validation.ValidateAsync(request, cancellationToken);
            if (!validate.IsValid)
            {
                return Result<Unit>.Failure(validate.Errors.First().ErrorMessage);
            }
            await _uow.EmployeeGradeRepository.AssignEmployeeToGrade(request.employeeId,request.gradeId,request.assignDate);

            var result = await _uow.SaveChangesAsync(cancellationToken) > 0;
            if(!result) {

                return Result<Unit>.Failure(Constant.ResultMessages.ErrorMessages.FAIL_WHILE_SAVING_DATA);
            }
            return Result<Unit>.Success(Unit.Value);
        }
    }
}
