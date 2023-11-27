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
            var products = await _context.Product
                .Where(e => EF.Property<int>(e, "IsDelete") == 0)
                .Join(
                    _context.Gellery.Where(g => g.IsThumbnail == 1),
                    product => product.Id,
                    gallery => gallery.ProductId,
                    (product, gallery) => new
                    {
                        Product = new Product
                        {
                            Id = product.Id,
                            CategoryId = product.CategoryId,
                            Title = product.Title,
                            UnitPrice = product.UnitPrice,
                            Description = product.Description,
                            Material = product.Material,
                            Instruction = product.Instruction
                        },
                        Link = gallery != null ? gallery.Link : null
                    }
                )
                .ToListAsync();

            return products;
        }
    }
}
