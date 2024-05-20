using al.Auth;
using BLL.ModelDTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Http;

namespace al.Controllers
{
    [EnableCors("*", "*", "*")]

    public class RestaurantController : ApiController
    {
        [HttpGet]
        [Route("api/restaurants")]
        public HttpResponseMessage AllRestaurants()
        {
            try
            {
                var data = RestaurantService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("api/restaurants/{id}")]
        public HttpResponseMessage GetOneRestaurant(int id)
        {
            try
            {
                var data = RestaurantService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("api/restaurants/create")]
        public HttpResponseMessage CreateRestaurant(RestaurantDTO restaurantDTO)
        {
            try
            {
                var data = RestaurantService.Create(restaurantDTO);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }


        [HttpPost]
        [Route("api/restaurants/update")]
        public HttpResponseMessage UpdateRestaurant(RestaurantDTO restaurantDTO)
        {
            try
            {
                var data = RestaurantService.Update(restaurantDTO);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [RoleAdmin]

        [HttpGet]
        [Route("api/restaurants/delete/{id}")]
        public HttpResponseMessage DeleteRestaurant(int id)
        {
            try
            {
                var data = RestaurantService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        [HttpGet]
        [Route("api/restaurants/{id}/products")]
        public HttpResponseMessage RestaurantProduct(int id)
        {
            try
            {
                var data = RestaurantService.GetwithRestaurantProduct(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpGet]
        [Route("api/restaurants/{id}/orders")]
        public HttpResponseMessage RestaurantOrder(int id)
        {
            try
            {
                var data = RestaurantService.GetwithRestaurantOrder(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

    }
}