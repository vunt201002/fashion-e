using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Fashion_e.BL.Base;
using Fashion_e.BL.DTOs.Product;
using Fashion_e.Common.Entities.Entities;
using Fashion_e.DL.Constracts;

namespace Fashion_e.BL.Services.ProductService
{
    public class ProductService : BaseService<Product, ProductDto>, IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(
            IProductRepository productRepository,
            IMapper mapper
        ) : base(productRepository, mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<object>> GetListWithThumbnail()
        {
            var list = await _productRepository.GetListWithThumbnail();

            return list;
        }
    }
}
