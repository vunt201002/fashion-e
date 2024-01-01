using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fashion_e.Common.Entities.Entities;
using Fashion_e.DL.Base;
using Fashion_e.DL.Constracts;
using Fashion_e.DL.Context;
using Microsoft.EntityFrameworkCore;

namespace Fashion_e.DL.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        private readonly DataContext _context;

        public ProductRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Object>> GetListWithThumbnail()
        {
            var products = _context.Product
                .Where(e => EF.Property<int>(e, "IsDelete") == 0)
                .GroupJoin(
                    _context.Gellery,
                    product => product.Id,
                    gallery => gallery.ProductId,
                    (product, galleries) => new
                    {
                        Product = new Product
                        {
                            Id = product.Id,
                            CategoryId = product.CategoryId,
                            Title = product.Title,
                            UnitPrice = product.UnitPrice,
                            Description = product.Description,
                            Material = product.Material,
                            Instruction = product.Instruction,
                            Code = product.Code
                        },
                        Images = galleries.Select(g => new
                        {
                            g.Link,
                            g.IsThumbnail
                        }).ToList(),
                    }
                )
                .AsEnumerable()
                .GroupJoin(
                    _context.SizeColorProduct,
                    result => result.Product.Id,
                    sizeColor => sizeColor.ProductId,
                    (result, sizeColors) => new
                    {
                        result.Product,
                        result.Images,
                        SizesColors = sizeColors
                            .Select(sc => new
                            {
                                Size = _context.SizeProduct
                                    .Where(s => s.Id == sc.SizeProductId)
                                    .OrderBy(s => s.Level)
                                    .FirstOrDefault(),
                                Color = _context.ColorProduct
                                    .FirstOrDefault(c => c.Id == sc.ColorProductId),
                                sc.Quantity,
                                sc.UnitInOrder
                            })
                            .ToList()
                    }
                )
                .ToList();

            return products;
        }
    }
}
