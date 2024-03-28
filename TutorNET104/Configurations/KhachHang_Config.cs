using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TutorNET104.Models;

namespace TutorNET104.Configurations
{
	public class KhachHang_Config : IEntityTypeConfiguration<KhachHang>
	{
		public void Configure(EntityTypeBuilder<KhachHang> builder)
		{
			builder.ToTable(nameof(KhachHang));

			builder.HasKey(a => a.Sdt);

		}
	}
}
