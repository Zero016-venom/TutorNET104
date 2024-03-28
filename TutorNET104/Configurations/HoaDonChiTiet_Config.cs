using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TutorNET104.Models;

namespace TutorNET104.Configurations
{
	public class HoaDonChiTiet_Config : IEntityTypeConfiguration<HoaDonChiTiet>
	{
		public void Configure(EntityTypeBuilder<HoaDonChiTiet> builder)
		{
			builder.ToTable("OrderDetails");

			builder.HasKey(a => a.Id);
			//builder.HasAlternateKey(a => a.Id);
			builder.HasOne(a => a.HoaDon)
				.WithMany(a => a.HoaDonChiTiets)
				.HasForeignKey(a => a.IdHD)
				.HasConstraintName("FK_HD_HDCT")
				.OnDelete(DeleteBehavior.Cascade);

			builder.HasOne(a => a.SanPham)
				.WithMany(a => a.HoaDonChiTiets)
				.HasForeignKey(a => a.IdSP);
		}
	}
}
