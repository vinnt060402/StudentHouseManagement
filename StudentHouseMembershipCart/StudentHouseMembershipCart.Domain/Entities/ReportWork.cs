using StudentHouseMembershipCart.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentHouseMembershipCart.Domain.Entities
{
    public class ReportWork : BaseAuditableEntity 
    { 
        /// <summary>
        /// Đánh dấu ngày staff đi làm 
        /// </summary>
        public DateTime WorkingDay { get; set; }
        public string? DescriptionProcess { get; set; }
        public string? Image { get; set; }

        [ForeignKey("Staff")]
        public Guid StaffId { get; set; }
        [ForeignKey("AttendReport")]
        public Guid AttendReportId { get; set; }

        // relationShip
        public virtual Staff Staff { get; set; }
        public virtual AttendReport AttendReport { get; set; }
    }

}
