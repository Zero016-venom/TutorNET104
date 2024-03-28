namespace TutorNET104.Models
{
	public class HoaDonChiTiet
	{
		public Guid Id { get; set; }
		public Guid IdSP { get; set; }
		public Guid IdHD { get; set; }
		public Decimal SellPrice { get; set; }
		public decimal SellAmout { get; set; }
		public int Status { get; set; }

		public virtual HoaDon HoaDon { get; set; }
		public virtual SanPham SanPham { get; set; }
	}
}
