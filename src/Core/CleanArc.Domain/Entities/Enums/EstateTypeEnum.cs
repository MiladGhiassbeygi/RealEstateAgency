using System.ComponentModel.DataAnnotations;

namespace CleanArc.Domain.Entities.Enums
{
    public enum EstateTypeEnum
    {
        [Display(Name = "آپارتمان")]
        Apartment = 1,
        [Display(Name = "ویلایی")]
        VillaHouse = 2,
        [Display(Name = "کلنگی")]
        OldHouse = 3,
        [Display(Name = "زمین")]
        Ground = 4,
        [Display(Name = "ویلا")]
        Villa = 5,
        [Display(Name = "تجاری")]
        Commercial = 6,
        [Display(Name = "اداری")]
        Office = 7,
        [Display(Name = "نامشخص")]
        Unknown = 8,
        [Display(Name = "سوویت")]
        Suite = 8

    }
}
