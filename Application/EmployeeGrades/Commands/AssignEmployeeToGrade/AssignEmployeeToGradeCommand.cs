using Domain.Shared;
using Domain.Interfaces;
using MediatR;
using Domain.Common;
using Application.Common.Messaging;

namespace Domain.EmployeeGrades.Commands.AssignEmployeeToGrade
{
    public record AssignEmployeeToGradeCommand(int employeeId,int gradeId,DateTime assignDate):ICommand< Unit>;
    public partial class AssignEmployeeToGradeCommandHandler : ICommandHandler<AssignEmployeeToGradeCommand, Unit>
    {
        private readonly IUOW _uow;

        public AssignEmployeeToGradeCommandHandler(IUOW uow) 
        {
            _uow = uow;
        }

        public  async Task<Result<Unit>> Handle(AssignEmployeeToGradeCommand request, CancellationToken cancellationToken)
        {
            var validation = new AssignEmployeeToGradeCommandValidator();
            var validate = await validation.ValidateAsync(request, cancellationToken);
            if (!validate.IsValid)
            {
                return  Result<Unit>.Failure<Unit>(new Error("", validate.Errors.First().ErrorMessage) );
            }
            await _uow.EmployeeGradeRepository.AssignEmployeeToGrade(request.employeeId,request.gradeId,request.assignDate);

            var result = await _uow.SaveChangesAsync(cancellationToken) > 0;
            if(!result) {

                return Result<Unit>.Failure<Unit>(new Error("",Constant.ResultMessages.ErrorMessages.FAIL_WHILE_SAVING_DATA));
            }
            return Result<Unit>.Success(Unit.Value);
        }
    }
}
