﻿using MediatR;
using StudentHouseMembershipCart.Application.Common.Response;

namespace StudentHouseMembershipCart.Application.Features.FeaturesPackage.Commands.CreateFP
{
    public class CreatePakageCommand : IRequest<SHMResponse>
    {
        public List<Guid> ListServiceId { get; set; } = null!;
        public string PackageName { get; set; } = null!;
        public int weekNumberBooking { get; set; }
        public int numberOfPerWeekDoPackage { get; set; }
        public string? DayDoServiceInWeek { get; set; }
        public string? ImageUrl { get; set; }
        public string? CreateBy { get; set; }
    }
}
