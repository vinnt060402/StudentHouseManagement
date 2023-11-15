using MediatR;
using StudentHouseMembershipCart.Application.Common.Response;

namespace StudentHouseMembershipCart.Application.Features.BookingDetails.Commands.UpdateBookingDetail
{
    public class UpdateBookingDetailCommand : IRequest<SHMResponse>
    {
        /// <summary>
        /// Nếu được gửi từ create booking detail xuống
        /// do bị trung service on going thì is re_new = true
        /// Các trường hợp khấc tùy vào việc mình truyền những gì
        /// </summary>
        public bool? IsRe_Newed { get; set; }
        /// <summary>
        /// Tương tự, Nếu được gửi từ create booking detail
        /// xuống do bị trùng service đang on going thì 
        /// renew start date sẽ được cập nhật dựa theo dữ liệu 
        /// gửi xuống
        /// Còn lại thì tùy vào trường  hợp user sẽ gửi những gì.
        /// </summary>
        public DateTime? RenewStartDate { get; set; }
        public Guid BookingDetailId { get; set; }
        public string? RemainingTaskDuration { get; set; }
        public Guid BookingId { get; set; }
        public int? QuantityOfPackageOrdered { get; set; }
        public Guid PackageId { get; set; }
        public string? UpdateBy { get; set; }
        public bool? IsDeleted { get; set; }
    }
}