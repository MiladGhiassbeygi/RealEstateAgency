using System.ComponentModel.DataAnnotations;

namespace CleanArc.Domain.Entities.Enums
{
    public enum ContractTypeEnum
    {
        [Display(Name = "رهن و اجاره")]
        Rent = 1,
        [Display(Name = "رهن")]
        Mortgage = 2,
        [Display(Name = "فروش")]
        Sell = 3,
        [Display(Name = "خرید")]
        Buy = 4,
        [Display(Name = "نامشخص")]
        Unknown = 5
    }
}
