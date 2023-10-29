using AutoMapper;
using MediatR;
using StudentHouseMembershipCart.Application.Common.Interfaces;
using StudentHouseMembershipCart.Application.Common.Response;

namespace StudentHouseMembershipCart.Application.Features.ReportWorks.Commands.UpdateReportWorkByStaff
{
    public class UpdateReportWorkByStaffCommandHandler : IRequestHandler<UpdateReportWorkByStaffCommand, SHMResponse>
    {
        private IApplicationDbContext _dbContext;
        private IMediator _mediator;
        private IMapper _mapper;

        public UpdateReportWorkByStaffCommandHandler(IApplicationDbContext dbContext, IMediator mediator, IMapper mapper)
        {
            _dbContext = dbContext;
            _mediator = mediator;
            _mapper = mapper;
        }

        public Task<SHMResponse> Handle(UpdateReportWorkByStaffCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
