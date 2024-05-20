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
    public class UserService
    {
        public static List<UserDTO> Get()
        {
            var data = DataAccessFactory.UserData().Get();

            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<User, UserDTO>();

            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<UserDTO>>(data);
            return mapped;
        }

        public static UserDTO Get(int id)
        {
            var data = DataAccessFactory.UserData().Get(id);

            var cfg = new MapperConfiguration(c => {
                c.CreateMap<User, UserDTO>();

            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<UserDTO>(data);
            return mapped;
        }

        public static bool Create(UserDTO userdto)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<UserDTO, User>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<User>(userdto);
            return DataAccessFactory.UserData().Create(mapped);
        }

        public static bool Update(UserDTO userdto)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<UserDTO, User>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<User>(userdto);
            return DataAccessFactory.UserData().Update(mapped);
        }

        public static bool Delete(int id)
        {
            var res = DataAccessFactory.UserData().Delete(id);
            return res;
        }
        public static OrderUserDTO GetwithOrderUser(int id)
        {
            var data = DataAccessFactory.UserData().Get(id);
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<User, OrderUserDTO>();


                c.CreateMap<Order, OrderDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<OrderUserDTO>(data);
            return mapped;

        }
        public static UserChatDTO GetwithUserChat(int id)
        {
            var data = DataAccessFactory.UserData().Get(id);
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<User, UserChatDTO>();

                c.CreateMap<Deliveryman, DeliverymanDTO>();
                c.CreateMap<Chat, ChatDto>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<UserChatDTO>(data);
            return mapped;

        }
        public static UserDTO SearchByUserName(String username)
        {
            var users = Get();
            var userbyname = (from i in users
                              where i.Username == username
                              select i).SingleOrDefault();
            return userbyname;

        }
        public static List<UserDTO> SearchByAdress(String adress)
        {
            var users = Get();
            var useradd = (from i in users
                           where i.Address == adress
                           select i).ToList();
            return useradd;

        }
        public static Token CheckTokenstring(string token)
        {
            var tokens = DataAccessFactory.TokenData().Get();
            var onetoke = (from i in tokens
                           where i.Tokens.Equals(token)
                           && i.ExpTime.Equals(null)
                           select i).SingleOrDefault();
            if (onetoke == null) { return null; }
            return onetoke;
        }
        public static UserDTO SearchByToken(String token)
        {

            var tokens = DataAccessFactory.TokenData().Get();
            var onetoke = (from i in tokens
                           where i.Tokens.Equals(token)
                           && i.ExpTime.Equals(null)
                           select i).SingleOrDefault();
            if (onetoke != null)
            {
                if (onetoke.Role.Equals("User"))
                {
                    var user = DataAccessFactory.UserData().Get(onetoke.UId);
                    var userdto = new UserDTO()
                    {
                        Id = user.Id,
                        Name = user.Name,
                        Username = user.Username,
                        Email = user.Email,
                        Password = user.Password,
                        Address = user.Address,
                        MobileNumber = user.MobileNumber,

                    };
                    return userdto;

                }
            }
            return null;


        }
        public static List<OrderDTO> SearchByTokengetorder(String token)
        {

            var tokens = DataAccessFactory.TokenData().Get();
            var onetoke = (from i in tokens
                           where i.Tokens.Equals(token)
                           && i.ExpTime.Equals(null)
                           select i).SingleOrDefault();

            if (onetoke.Role.Equals("User"))
            {
                var user = DataAccessFactory.UserData().Get(onetoke.UId);
                var userdto = new UserDTO()
                {
                    Id = user.Id,
                    Name = user.Name,
                    Username = user.Username,
                    Email = user.Email,
                    Password = user.Password,
                    Address = user.Address,
                    MobileNumber = user.MobileNumber,

                };
                var order = DataAccessFactory.OrderData().Get();
                var list2 = new List<OrderDTO>();
                var myorder = (from i in order
                               where i.Uid == userdto.Id
                               select i).ToList();
                foreach (var item in myorder)
                {
                    var orderList = new List<OrderDetailsDTO>();
                    foreach (var item2 in item.OrderDetails)
                    {
                        orderList.Add(new OrderDetailsDTO()
                        {
                            Id = item2.Id,
                            Oid = item2.Oid,
                            Pid = item2.Pid,
                            Price = item2.Price,
                            Quantity = item2.Quantity,

                        });
                    }
                    list2.Add(new OrderDTO()
                    {
                        Id = item.Id,
                        Rid = item.Rid,
                        Uid = item.Uid,
                        RestaurantName = item.RestaurantName,
                        lat = item.lat,
                        lan = item.lan,
                        Date = item.Date,
                        OrderStatus = item.OrderStatus,
                        Amount = item.Amount,
                        OrderDetailsDTOs = orderList

                    }); ;
                }

                return list2;
            }
            return null;


        }


    }
}
