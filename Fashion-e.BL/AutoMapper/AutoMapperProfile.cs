using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Fashion_e.BL.DTOs.Category;
using Fashion_e.BL.DTOs.ColorProduct;
using Fashion_e.BL.DTOs.Customer;
using Fashion_e.BL.DTOs.Employee;
using Fashion_e.BL.DTOs.Feedback;
using Fashion_e.BL.DTOs.Gallery;
using Fashion_e.BL.DTOs.Order;
using Fashion_e.BL.DTOs.OrderDetail;
using Fashion_e.BL.DTOs.Product;
using Fashion_e.BL.DTOs.Shipper;
using Fashion_e.BL.DTOs.SizeColorProduct;
using Fashion_e.BL.DTOs.SizeProduct;
using Fashion_e.Common.Entities.Entities;

namespace Fashion_e.BL.AutoMapper
{
    /// <summary>
    /// map giữa entity và dto
    /// </summary>
    /// created by: ntvu (20/11/2023)
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CategoryDTO, Category>();
            CreateMap<SizeProductDto, SizeProduct>();
            CreateMap<ColorProductDto, ColorProduct>();
            CreateMap<ProductDto, Product>();
            CreateMap<GalleryDTO, Gallery>();
            CreateMap<SizeColorProductDTO, SizeColorProduct>();
            CreateMap<FeedbackDTO, Feedback>();
            CreateMap<CustomerDTO, Customer>();
            CreateMap<EmployeeDTO, Employee>();
            CreateMap<ShipperDTO, Shipper>();
            CreateMap<OrderDTO, Order>();
            CreateMap<OrderDetailDTO, OrderDetail>();
        }
    }
}
