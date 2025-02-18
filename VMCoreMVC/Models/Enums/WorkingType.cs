using System.ComponentModel.DataAnnotations;

namespace VMCoreMVC.Models.Enums
{
    public enum WorkingType
    {
        [Display(Name = "Tam Zamanlı")]
        FullTime,
        [Display(Name = "Yarı Zamanlı")]
        PartTime,
        [Display(Name = "Proje Bazlı")]
        ProjectBased,
        [Display(Name = "Serbest Zamanlı")]
        FreeLance
    }
}
