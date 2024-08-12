using System.ComponentModel.DataAnnotations;

namespace CleanArc.Domain.Entities.Enums
{
    public enum EstateStatusTypeEnum
    {
        [Display(Name = "تخلیه")]
        Vacant = 1,
        [Display(Name = "عدم تخلیه")]
        UnVacant = 2,
        [Display(Name = "کلید نخورده")]
        Unlocked = 3,
        [Display(Name = "پیش فروش")]
        PreSell = 4,
        [Display(Name = "نامشخص")]
        Unknown = 5,
        [Display(Name = "بازسازی شده")]
        ReBuilt = 6
    }
}
