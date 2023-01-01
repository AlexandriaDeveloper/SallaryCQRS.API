using Domain.Shared;
using Domain.Interfaces;
using AutoMapper;
using Domain.Models;
using MediatR;
using Application.Common.Messaging;
using Domain.Constants;
namespace Domain.EmployeeSubscriptions.Commands.AssignEmployeeToSubscription
{
    public record AssignEmployeeToSubscriptionCommand(EmployeeSubscriptionDto employeeSubscriptionModel) :ICommand<Unit>;

    public class AssignEmployeeToSubscriptionCommandHandler : ICommandHandler<AssignEmployeeToSubscriptionCommand, Unit>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;
        private readonly IAuthService _authService;

            public AssignEmployeeToSubscriptionCommandHandler(IUOW uow,IMapper mapper,IAuthService authService) 
            {
            _uow = uow;
            _mapper = mapper;
            _authService = authService;
        }

        public async  Task<Result<Unit>> Handle(AssignEmployeeToSubscriptionCommand request, CancellationToken cancellationToken)
        {
            var employeeSubscripToDb = _mapper.Map<EmployeeSubscription>(request.employeeSubscriptionModel);
            employeeSubscripToDb.CreatedBy=_authService.GetCurrentLoggedInUser();
            employeeSubscripToDb.CreatedDate= DateTime.Now;
            await _uow.EmployeeSubscriptionRepository.AddItem(employeeSubscripToDb);

            var result = await _uow.SaveChangesAsync(cancellationToken)         ;
        
            if (result != Enums.SaveState.Saved) {
                return Result<Unit>.Failure(result);
            }
            return Result<Unit>.Success(Unit.Value);
        }
    }
}
