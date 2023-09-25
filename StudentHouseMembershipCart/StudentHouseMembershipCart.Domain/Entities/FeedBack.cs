using StudentHouseMembershipCart.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentHouseMembershipCart.Domain.Entities
{
    public class FeedBack : BaseAuditableEntity 
    {
        public string FeedBackName { get; set; }
        public string FeedBackDescription { get; set; }
        public string FeedBackImage { get; set;}
        public string FeedBackRating { get; set;}

        [ForeignKey("Student")]
        public Guid StudentId { get; set; }
        [ForeignKey("AttendReport")]
        public Guid AttendReportId { get; set; }

        // relationShip
        public virtual Student Students { get; set; }
        public virtual AttendReport AttendReports { get; set; }

        public IList<AttendReport> AttendReport { get; private set; }
        public IList<Student> Student { get; private set; }
    }

}
