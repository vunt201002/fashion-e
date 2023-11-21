using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fashion_e.Common.Entities.Base;

namespace Fashion_e.Common.Entities.Entities
{
    public class Category : BaseTreeEntity<Category>
    {
        public string Name { get; set; }        // tên danh mục
    }
}
