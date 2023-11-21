using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion_e.Common.Entities
{
    /// <summary>
    /// lớp trả về dữ liệu
    /// dạng cây
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BaseTreeEntity<T> : BaseEntity where T : class
    {
        public Guid ParentId { get; set; }                              // id node cha

        public T Parent { get; set; }                                   // node cha
        public IEnumerable<T> Children { get; set; } = new List<T>();   // list node con
    }
}
