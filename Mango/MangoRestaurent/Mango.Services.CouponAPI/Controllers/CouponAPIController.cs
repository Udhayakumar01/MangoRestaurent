using Mango.Services.CouponAPI.Data;
using Mango.Services.CouponAPI.Models;
using Mango.Services.CouponAPI.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mango.Services.CouponAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CouponAPIController : ControllerBase
    {
        public readonly AppDbContext _db;
        private ResponseDto _response;
        public CouponAPIController(AppDbContext db) {
            _db = db;
            _response = new ResponseDto();
        }
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                IEnumerable<Coupon> coupons = _db.Coupons.ToList();
                _response.Result = coupons;
                return Ok(_response);
            }
            catch (Exception ex) {
                _response.Message = ex.Message;
                _response.IsSuccess = false;
            }
            return Ok(_response);
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult Get(int id)
        {
            try
            {
                Coupon coupons = _db.Coupons.First(c => c.CouponId == id);
                _response.Result = coupons;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.Message = ex.Message;
                _response.IsSuccess = false;
            }
            return Ok(_response);
        }
    }
}
