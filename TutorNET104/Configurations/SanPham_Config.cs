using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TutorNET104.Models;

namespace TutorNET104.Configurations
{
	public class SanPham_Config : IEntityTypeConfiguration<SanPham>
	{
		public void Configure(EntityTypeBuilder<SanPham> builder)
		{
			// Cấu hình tên bảng
			builder.ToTable("Product");

			// Cấu hình thuộc tính
			builder.HasKey(a => a.Id);

			builder.Property(a => a.Name).IsRequired().HasColumnType("nvarchar(50)");

			builder.Property(a => a.Description).IsRequired().HasColumnType("nvarchar(200)");

		}
	}
}
