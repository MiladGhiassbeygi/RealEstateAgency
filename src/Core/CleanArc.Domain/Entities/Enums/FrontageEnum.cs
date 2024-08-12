using System.ComponentModel.DataAnnotations;

namespace CleanArc.Domain.Entities.Enums
{
    public enum FrontageEnum
    {
        [Display(Name = "سنگی")]
        Stone = 1,
        [Display(Name = "آجر")]
        Brick = 2,
        [Display(Name = "سیمان")]
        Cement = 3,
        [Display(Name = "نامشخص")]
        Unknown = 4,
    }
}
