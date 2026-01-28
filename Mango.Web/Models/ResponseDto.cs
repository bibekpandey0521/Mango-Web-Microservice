namespace Mango.Web.Models
{
    public class ResponseDto
    {
        //public List<GetCouponDTO>? Result { get; set; }
        public object? Result { get; set; }
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }

    //public class GetCouponDTO
    //{
    //   public int couponId { get; set; }
    //   public string couponCode { get; set; }
    //   public int discountAmount  { get; set; }
    //   public int minAmount { get; set; }
    //}
}
