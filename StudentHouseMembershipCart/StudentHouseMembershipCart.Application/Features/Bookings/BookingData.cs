namespace StudentHouseMembershipCart.Application.Features.Bookings
{
    public class BookingData
    {
        public Guid Id { get; set; }
        public string? Contract { get; set; }
        public double TotalPay { get; set; }
        public Guid ApartmentId { get; set; }
        /// <summary>
        /// If StatusContract is 0 -> On going
        /// Is 1 -> Finished
        /// </summary>
        public string? StatusContract { get; set; }
        public DateTime Created { get; set; }
        public bool IsDeleted { get; set; }
    }
}
