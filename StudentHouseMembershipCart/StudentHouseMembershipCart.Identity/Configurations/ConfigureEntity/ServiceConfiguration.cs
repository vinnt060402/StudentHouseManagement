using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentHouseMembershipCart.Domain.Entities;

namespace StudentHouseMembershipCart.Identity.Configurations.ConfigureEntity
{
    internal class ServiceConfiguration : IEntityTypeConfiguration<Domain.Entities.Service>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Service> builder)
        {
            builder.HasData(
                new Domain.Entities.Service
                {
                    Id = Guid.Parse("FA87282B-0C28-4DC7-831D-E1D8F8026270"),
                    ServiceName = "Dịch vụ rửa xe máy",
                    ServiceDescription = "Làm mới và làm sạch xe máy, lau chùi và bảo dưỡng các bộ phận khác như bánh xe, đèn, và ống xả, xúc bình xăng",
                    Price = 50000,
                    Image = "https://res.cloudinary.com/dqqqgyqjl/image/upload/v1698421423/opuaf4ugi3y5iutu6vvp.jpg?fbclid=IwAR3rtgIeRmGXgoilgjIh0hupzfpXJCv_rArlNgBqTMkgRYwPL9wV0HJ9rEU",
                    CategoryId = Guid.Parse("8ABB3DDA-208B-4397-93C0-3A5269A90E3D"),
                },
                new Domain.Entities.Service
                {
                    Id = Guid.Parse("9D3A81B8-A470-4F46-861E-772D55D73668"),
                    ServiceName = "Dịch vụ rửa xe hơi",
                    ServiceDescription = "Làm mới và làm sạch xe Hơi, lau chùi và bảo dưỡng các bộ phận khác như bánh xe, đèn, và ống xả",
                    Price = 70000,
                    Image = "https://res.cloudinary.com/dqqqgyqjl/image/upload/v1698421423/opuaf4ugi3y5iutu6vvp.jpg?fbclid=IwAR3rtgIeRmGXgoilgjIh0hupzfpXJCv_rArlNgBqTMkgRYwPL9wV0HJ9rEU",
                    CategoryId = Guid.Parse("8ABB3DDA-208B-4397-93C0-3A5269A90E3D"),
                },
                new Domain.Entities.Service
                {
                    Id = Guid.Parse("7635D149-2A74-4562-B779-C81056594BFB"),
                    ServiceName = "Giặt áo vest",
                    ServiceDescription = "giặt sạch, làm mềm vải, và bảo quản cẩn thận để duy trì vẻ ngoại hình và chất lượng tốt nhất.",
                    Price = 50000,
                    Image = "https://res.cloudinary.com/dqqqgyqjl/image/upload/v1698421423/opuaf4ugi3y5iutu6vvp.jpg?fbclid=IwAR3rtgIeRmGXgoilgjIh0hupzfpXJCv_rArlNgBqTMkgRYwPL9wV0HJ9rEU",
                    CategoryId = Guid.Parse("A3CCB973-D6C4-4EF4-AE4B-36A97429A0B0"),
                },
                new Domain.Entities.Service
                {
                    Id = Guid.Parse("E430FCFB-DE6A-4C64-A6CA-B607E1357843"),
                    ServiceName = "Giặt quần áo hằng ngày",
                    ServiceDescription = "giặt sạch, làm mềm vải, và bảo quản cẩn thận để duy trì vẻ ngoại hình và chất lượng tốt nhất.",
                    Price = 25000,
                    Image = "https://res.cloudinary.com/dqqqgyqjl/image/upload/v1698421423/opuaf4ugi3y5iutu6vvp.jpg?fbclid=IwAR3rtgIeRmGXgoilgjIh0hupzfpXJCv_rArlNgBqTMkgRYwPL9wV0HJ9rEU",
                    CategoryId = Guid.Parse("A3CCB973-D6C4-4EF4-AE4B-36A97429A0B0"),
                },
                new Domain.Entities.Service
                {
                    Id = Guid.Parse("29140864-8E89-41B6-8FD7-A440800E6E00"),
                    ServiceName = "Hỗ trợ vay tiền học",
                    ServiceDescription = "Cung cấp giải pháp tài chính linh hoạt cho sinh viên, " +
                    "cho phép họ vay tiền để chi trả học phí, sách vở, chi phí sinh hoạt hàng ngày và các nhu cầu khác " +
                    "liên quan đến việc học tập. Quy trình đơn giản và linh hoạt, cung cấp các lựa chọn vay phù hợp với điều kiện " +
                    "tài chính của sinh viên, giúp họ tiếp cận giáo dục một cách thuận lợi.",
                    Price = 3000000,
                    Image = "https://res.cloudinary.com/dqqqgyqjl/image/upload/v1698421423/opuaf4ugi3y5iutu6vvp.jpg?fbclid=IwAR3rtgIeRmGXgoilgjIh0hupzfpXJCv_rArlNgBqTMkgRYwPL9wV0HJ9rEU",
                    CategoryId = Guid.Parse("8940E7F6-FD91-4402-A515-B9D55448C522"),
                },
                new Domain.Entities.Service
                {
                    Id = Guid.Parse("A9A16DCF-6C63-4392-9EC2-BE727FCD6081"),
                    ServiceName = "Rửa xe đạp",
                    ServiceDescription = "Làm mới và làm sạch xe đạp, bơm bánh xe",
                    Price = 20000,
                    Image = "https://res.cloudinary.com/dqqqgyqjl/image/upload/v1698421423/opuaf4ugi3y5iutu6vvp.jpg?fbclid=IwAR3rtgIeRmGXgoilgjIh0hupzfpXJCv_rArlNgBqTMkgRYwPL9wV0HJ9rEU",
                    CategoryId = Guid.Parse("8ABB3DDA-208B-4397-93C0-3A5269A90E3D"),
                },
                new Domain.Entities.Service
                {
                    Id = Guid.Parse("1E064ACA-EF1A-4705-9931-A49A807765FD"),
                    ServiceName = "Chuyển nhà",
                    ServiceDescription = "đóng gói, vận chuyển và xếp đặt đồ đạc của sinh viên một cách cẩn thận.",
                    Price = 600000,
                    Image = "https://res.cloudinary.com/dqqqgyqjl/image/upload/v1698421423/opuaf4ugi3y5iutu6vvp.jpg?fbclid=IwAR3rtgIeRmGXgoilgjIh0hupzfpXJCv_rArlNgBqTMkgRYwPL9wV0HJ9rEU",
                    CategoryId = Guid.Parse("375A894D-E8E5-4A84-A0B8-09F907992B46"),
                },
                new Domain.Entities.Service
                {
                    Id = Guid.Parse("16209D12-4E67-41E5-B419-F3285B8958E6"),
                    ServiceName = "Giao nước uống",
                    ServiceDescription = "Nước được đóng trong các bình chất lượng cao, đảm bảo vệ sinh và an toàn.",
                    Price = 60000,
                    Image = "https://res.cloudinary.com/dqqqgyqjl/image/upload/v1698421423/opuaf4ugi3y5iutu6vvp.jpg?fbclid=IwAR3rtgIeRmGXgoilgjIh0hupzfpXJCv_rArlNgBqTMkgRYwPL9wV0HJ9rEU",
                    CategoryId = Guid.Parse("375A894D-E8E5-4A84-A0B8-09F907992B46"),
                },
                new Domain.Entities.Service
                {
                    Id = Guid.Parse("FBDA5A61-C0E1-4039-97A5-841FB84EC5CE"),
                    ServiceName = "Nấu cơm",
                    ServiceDescription = "đi chợ, mua thực phẩm, chế biến, tính tiền",
                    Price = 100000,
                    Image = "https://res.cloudinary.com/dqqqgyqjl/image/upload/v1698421423/opuaf4ugi3y5iutu6vvp.jpg?fbclid=IwAR3rtgIeRmGXgoilgjIh0hupzfpXJCv_rArlNgBqTMkgRYwPL9wV0HJ9rEU",
                    CategoryId = Guid.Parse("9DF988F5-0382-4939-8EEE-09D47B182BBB"),
                },
                new Domain.Entities.Service
                {
                    Id = Guid.Parse("30743744-754B-4A87-B828-6186CCC7ECE6"),
                    ServiceName = "Dọn dẹp nhà cửa",
                    ServiceDescription = "quét nhà, lau nhà, rửa chén, xếp quần áo, đổ rác",
                    Price = 120000,
                    Image = "https://res.cloudinary.com/dqqqgyqjl/image/upload/v1698421423/opuaf4ugi3y5iutu6vvp.jpg?fbclid=IwAR3rtgIeRmGXgoilgjIh0hupzfpXJCv_rArlNgBqTMkgRYwPL9wV0HJ9rEU",
                    CategoryId = Guid.Parse("21291667-7546-4825-9BAD-840D648900A3"),
                },
                new Domain.Entities.Service
                {
                    Id = Guid.Parse("4FCC0684-AD33-433F-9338-D9E949B6F0D8"),
                    ServiceName = "Sửa ống nước",
                    ServiceDescription = "kiểm tra, xác định và khắc phục vấn đề, Thay van, tra keo",
                    Price = 200000,
                    Image = "https://res.cloudinary.com/dqqqgyqjl/image/upload/v1698421423/opuaf4ugi3y5iutu6vvp.jpg?fbclid=IwAR3rtgIeRmGXgoilgjIh0hupzfpXJCv_rArlNgBqTMkgRYwPL9wV0HJ9rEU",
                    CategoryId = Guid.Parse("BA0F3F23-9425-44AD-9D73-A7608381FD5F"),
                },
                new Domain.Entities.Service
                {
                    Id = Guid.Parse("6BBD52B8-A4B7-407E-BABA-A4F4FCA65D24"),
                    ServiceName = "Sửa wifi",
                    ServiceDescription = "kiểm tra, xác định và khắc phục vấn đề",
                    Price = 50000,
                    Image = "https://res.cloudinary.com/dqqqgyqjl/image/upload/v1698421423/opuaf4ugi3y5iutu6vvp.jpg?fbclid=IwAR3rtgIeRmGXgoilgjIh0hupzfpXJCv_rArlNgBqTMkgRYwPL9wV0HJ9rEU",
                    CategoryId = Guid.Parse("BA0F3F23-9425-44AD-9D73-A7608381FD5F"),
                }
            );
        }
    }
}
