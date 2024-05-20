using BLL.ModelDTOs;
using DAL.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace BLL.Services
{
    public class RestaurantService
    {

        public static List<RestaurantDTO> Get()
        {
            var data = DataAccessFactory.RestaurantData().Get();

            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Restaurant, RestaurantDTO>();

            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<RestaurantDTO>>(data);
            return mapped;
        }

        public static RestaurantDTO Get(int id)
        {
            var data = DataAccessFactory.RestaurantData().Get(id);

            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Restaurant, RestaurantDTO>();

            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<RestaurantDTO>(data);
            return mapped;
        }

        public static bool Create(RestaurantDTO restaurantdto)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<RestaurantDTO, Restaurant>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Restaurant>(restaurantdto);
            return DataAccessFactory.RestaurantData().Create(mapped);
        }

        public static bool Update(RestaurantDTO restaurantdto)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<RestaurantDTO, Restaurant>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Restaurant>(restaurantdto);
            return DataAccessFactory.RestaurantData().Update(mapped);
        }

        public static bool Delete(int id)
        {
            var res = DataAccessFactory.RestaurantData().Delete(id);
            return res;
        }
        public static RestaurantProductDTO GetwithRestaurantProduct(int id)
        {
            var data = DataAccessFactory.RestaurantData().Get(id);
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Restaurant, RestaurantProductDTO>();
                c.CreateMap<Cuisine, CuisineDTO>();

                c.CreateMap<Product, ProductDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<RestaurantProductDTO>(data);
            return mapped;

        }
        public static RestaurantOrderDTO GetwithRestaurantOrder(int id)
        {
            var data = DataAccessFactory.RestaurantData().Get(id);
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Restaurant, RestaurantOrderDTO>();
                c.CreateMap<User, UserDTO>();

                c.CreateMap<Order, OrderDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<RestaurantOrderDTO>(data);
            return mapped;

        }



    }
}
