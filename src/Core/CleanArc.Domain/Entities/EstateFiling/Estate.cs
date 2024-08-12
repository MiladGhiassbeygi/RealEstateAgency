using CleanArc.Domain.Common;
using CleanArc.Domain.Entities.Enums;

namespace CleanArc.Domain.Entities.EstateFiling
{
    public class Estate : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Lat { get; set; }
        public string Lng { get; set; }
        public int Age { get; set; }
        public int Area { get; set; } // By Meter
        public int Infrastructure { get; set; } // By Meter
        public int FrontOfEstate { get; set; } // By Meter
      
        public DateTime InsertDate { get; set; } = DateTime.Now;
        public DateTime? VacateTime { get; set; }
        public EstateTypeEnum EstateTypeId { get; set; } = EstateTypeEnum.Unknown;
        public EstateStatusTypeEnum EstateStatusTypeId { get; set; } = EstateStatusTypeEnum.Unknown;
        public FrontageEnum FrontageEnumId { get; set; } = FrontageEnum.Unknown;
        public ContractTypeEnum ContractTypeId { get; set; } = ContractTypeEnum.Unknown;
        public DocumentTypeEnum DocumentType { get; set; } = DocumentTypeEnum.FullDocument;
    }
}
