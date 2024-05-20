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
    public class DeliverymanService
    {
        public static List<DeliverymanDTO> Get()
        {
            var data = DataAccessFactory.DeliverymanData().Get();

            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Deliveryman, DeliverymanDTO>();
                c.CreateMap<DeliverymanType, DeliverymanTypeDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<DeliverymanDTO>>(data);
            return mapped;
        }

        public static DeliverymanDTO Get(int id)
        {
            var data = DataAccessFactory.DeliverymanData().Get(id);

            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Deliveryman, DeliverymanDTO>();
                c.CreateMap<DeliverymanType, DeliverymanTypeDTO>();

            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<DeliverymanDTO>(data);
            return mapped;
        }

        public static bool Create(DeliverymanDTO deliverymandto)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<DeliverymanDTO, Deliveryman>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Deliveryman>(deliverymandto);
            return DataAccessFactory.DeliverymanData().Create(mapped);
        }
        public static bool Update(DeliverymanDTO deliverymandto)
        {
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<DeliverymanDTO, Deliveryman>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Deliveryman>(deliverymandto);
            return DataAccessFactory.DeliverymanData().Update(mapped);
        }

        public static bool Delete(int id)
        {
            var res = DataAccessFactory.DeliverymanData().Delete(id);
            return res;
        }

        public static DeliveryManDeliveryLogDTO GetwithDeliveryManDeliveryLog(int id)
        {
            var data = DataAccessFactory.DeliverymanData().Get(id);
            var cfg = new MapperConfiguration(c => {
                c.CreateMap<Deliveryman, DeliveryManDeliveryLogDTO>();
                c.CreateMap<Order, OrderDTO>();

                c.CreateMap<DeliveryLog, DeliveryLogDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<DeliveryManDeliveryLogDTO>(data);
            return mapped;

        }
    }
}
