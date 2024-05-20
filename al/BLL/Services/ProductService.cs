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
    public class ProductService
    {
        public static List<ProductDTO> Get()
        {
            var data = DataAccessFactory.ProductData().Get();

            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Product, ProductDTO>();

            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<List<ProductDTO>>(data);
            return mapped;
        }

        public static ProductDTO Get(int id)
        {
            var allpro = Get();
            var pro = (from item in allpro
                       where item.Id == id
                       select item).SingleOrDefault();
            return pro;
        }

        public static bool Create(ProductDTO productdto)
        {
            var product = new Product();
            product.Id = productdto.Id;
            product.Name = productdto.Name;
            product.Price = productdto.Price;
            product.Quantity = productdto.Quantity;
            product.Rid = productdto.Rid;
            product.Cid = productdto.Cid;


            return DataAccessFactory.ProductData().Create(product);
        }

        public static bool Update(ProductDTO productdto)
        {
            var product = new Product();
            product.Id = productdto.Id;
            product.Name = productdto.Name;
            product.Price = productdto.Price;
            product.Quantity = productdto.Quantity;
            product.Rid = productdto.Rid;
            product.Cid = productdto.Cid;

            return DataAccessFactory.ProductData().Update(product);

        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.ProductData().Delete(id);
        }
    }
}
