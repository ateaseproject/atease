using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Paran.Framework.Resources;

namespace Paran.Framework.Extenstions.DateTime
{
    public enum PersianMonths
    {
        [Display(Name = "PersianMonthFarvardin", ResourceType = typeof(DisplayNameResource))]
        Farvardin = 1,
        [Display(Name = "PersianMonthOrdibehesht", ResourceType = typeof(DisplayNameResource))]
        Ordibehesht = 2,
        [Display(Name = "PersianMonthKhordad", ResourceType = typeof(DisplayNameResource))]
        Khordad = 3,
        [Display(Name = "PersianMonthTir", ResourceType = typeof(DisplayNameResource))]
        Tir = 4,
        [Display(Name = "PersianMonthMordad", ResourceType = typeof(DisplayNameResource))]
        Mordad = 5,
        [Display(Name = "PersianMonthShahrivar", ResourceType = typeof(DisplayNameResource))]
        Shahrivar = 6,
        [Display(Name = "PersianMonthMehr", ResourceType = typeof(DisplayNameResource))]
        Mehr = 7,
        [Display(Name = "PersianMonthAban", ResourceType = typeof(DisplayNameResource))]
        Aban = 8,
        [Display(Name = "PersianMonthAzar", ResourceType = typeof(DisplayNameResource))]
        Azar = 9,
        [Display(Name = "PersianMonthDey", ResourceType = typeof(DisplayNameResource))]
        Dey = 10,
        [Display(Name = "PersianMonthBahman", ResourceType = typeof(DisplayNameResource))]
        Bahman = 11,
        [Display(Name = "PersianMonthEsfand", ResourceType = typeof(DisplayNameResource))]
        Esfand = 12
    }
}
