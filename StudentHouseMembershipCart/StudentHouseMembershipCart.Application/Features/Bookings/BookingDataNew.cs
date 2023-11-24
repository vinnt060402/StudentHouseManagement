using StudentHouseMembershipCart.Application.Features.Apartments;

namespace StudentHouseMembershipCart.Application.Features.Bookings
{
    public class BookingDataNew
    {
        public Guid Id { get; set; }
        public string? StudentName { get; set; }
        public double TotalPay { get; set; }
        public Guid ApartmentId { get; set; }
        public ApartmentDto? ApartmentData { get; set; }
        /// <summary>
        /// If StatusContract is 0 -> On going
        /// Is 1 -> Finished
        /// </summary>
        public string? StatusContract { get; set; }
        public DateTime Created { get; set; }/*
        /// <summary>
        /// List Service có trong Booking này
        /// </summary>
        public List<ServiceOfBookingDetail>? ListServiceOfBookingDetail { get; set; }*/

    }
    public class ServiceOfBookingDetail
    {
        public string? ServiceName { get; set; }
        public Guid ServiceId { get; set; }
        /// <summary>
        /// Đại diện đơn vị
        /// </summary>
        public string? Unit { get; set; }
        /// <summary>
        /// Những cái Booking Detail mà có chứa cái dịch vụ này
        /// </summary>
        public List<BookingDetailDataNew>? BookingDetailThatServiceIsBelongTo { get; set; } 
    }
    public class BookingDetailDataNew
    {
        public Guid BookingDetailId { get; set; }
        //BE tự tạo
        public string? BookingDetailName { get; set; }
        /// <summary>
        /// Ngay bat dau dich vu
        /// </summary>
        public DateTime? StartDate { get; set; }
        /// <summary>
        /// Ngay ket thuc dich vu
        /// </summary>
        public DateTime? EndDate { get; set; }
        /// <summary>
        /// field dùng để check xem booking này là của Package hoặc của service
        /// </summary>
        public string? BookingDetailType {  get; set; }
        /// <summary>
        /// Số lượng của Service trong cái booking detail này
        /// </summary>
        public int RemainingTaskDuration { get; set; }
    }
}
