namespace TutorNET104.Models
{
	public class SanPham
	{
		public Guid Id { get; set; }
		public string? Name { get; set; }
		public string? Description { get; set; }
		public decimal? Price { get; set; }
		public int Stock { get; set; }
		public int Status { get; set; }

		public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
	}
}
