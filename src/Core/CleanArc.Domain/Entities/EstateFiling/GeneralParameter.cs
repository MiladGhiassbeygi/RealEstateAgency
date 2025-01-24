using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArc.Domain.Entities.EstateFiling
{
    public class GeneralParameter
    {
        public int Id { get; set; }
        public int Title{ get; set; }
        public string Code{ get; set; }
        public string MainType{ get; set; }
        public int ParentId{ get; set; }
        public bool Visible{ get; set; }
        public int Rank{ get; set; }
        
    }}
