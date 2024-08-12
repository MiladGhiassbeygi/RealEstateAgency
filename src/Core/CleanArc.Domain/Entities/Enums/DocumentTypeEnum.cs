using System.ComponentModel.DataAnnotations;

namespace CleanArc.Domain.Entities.Enums
{
    public enum DocumentTypeEnum
    {

        [Display(Name = "سند مشاع")]
        CommonDocument = 1,
        [Display(Name = "سند شش دانگ")]
        FullDocument = 2,
        [Display(Name = "سند مفروز")]
        AssumedDocument = 3,
        [Display(Name = "سند منگوله دار")]
        TasselDocument = 4,
        [Display(Name = "سند تک برگ")]
        SingleSheetDocument = 5,
        [Display(Name = "سند اعیان")]
        ClearDocument = 6,
        [Display(Name = "سند عرصه")]
        ArenaDocument = 7,
        [Display(Name = "سند وقفی")]
        EndowmentDocument = 8

    }
}
