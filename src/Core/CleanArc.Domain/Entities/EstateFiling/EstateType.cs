using CleanArc.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArc.Domain.Entities.EstateFiling
{
    public class EstateType : BaseEntity<byte>
    {
        public string Title { get; set; }
    }
}
