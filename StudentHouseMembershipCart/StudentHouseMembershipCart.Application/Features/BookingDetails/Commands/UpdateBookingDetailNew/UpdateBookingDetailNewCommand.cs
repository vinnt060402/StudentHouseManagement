using MediatR;
using StudentHouseMembershipCart.Application.Common.Response;

namespace StudentHouseMembershipCart.Application.Features.BookingDetails.Commands.UpdateBookingDetailNew
{
    /// <summary>
    /// Dùng để update trạng thái Booking detail cho những Bookingdetail được đăng kí
    /// mới mà bị trùng
    /// VD: Có 1 bookingdetail khác đang trong trạng thái renew = false
    /// và người dùng thay vì chọn ở phần đăng ký tiếp thì lại vô vỏ hàng mua
    /// Thì ta update 2 status lại rồi đăng ký một package mới
    /// </summary>
    public class UpdateBookingDetailNewCommand : IRequest<SHMResponse>
    {
        public Guid BookingDetailId { get; set; }
        public DateTime RenewStartDate { get; set; }
    }
}