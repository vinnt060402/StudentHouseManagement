namespace StudentHouseMembershipCart.Application.Features.Feedbacks.Queries
{
    public class FeedBackData
    {
        public string? FeedBackName { get; set; }
        public string? FeedBackDescription { get; set; }
        public string? FeedBackImage { get; set; }
        public string? FeedBackRating { get; set; }
        public string? DateFeedBack { get; set; }
        /// <summary>
        /// 0. Can not Feedback
        /// 1. Can Feedback
        /// 2. Feedbacked
        /// </summary>
        public int FeedBackStatus { get; set; }
    }
}