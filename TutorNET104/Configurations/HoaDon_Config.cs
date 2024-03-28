using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TutorNET104.Models;

namespace TutorNET104.Configurations
{
	public class HoaDon_Config : IEntityTypeConfiguration<HoaDon>
	{
		public void Configure(EntityTypeBuilder<HoaDon> builder)
		{
			builder.ToTable("Order");

			builder.HasKey(o => o.Id);

			builder.HasOne(o => o.KhachHang)
				.WithMany(o => o.HoaDons).HasForeignKey(o => o.idKhachHang);
		}
	}
}
