namespace TutorNET104.Models
{
	public class HoaDon
	{
		public Guid Id { get; set; }
		public DateTime SellDate { get; set; }
		public Decimal TotalMoney { get; set; }
		public string idKhachHang { get; set; }
		public int Status { get; set; }
		// Tạo navigation để thiết lập quan hệ

		public virtual KhachHang KhachHang { get; set; }
		public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
	} 
}
