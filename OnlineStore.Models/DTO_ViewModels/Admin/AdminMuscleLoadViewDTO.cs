﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Data.DTO_ViewModels
{
    public class AdminMuscleLoadViewDTO
    {
        [Key]
        public int MuscleLoadId { get; set; }
        [StringLength(255)]
        public string MuscleName { get; set; }

        public bool Disabled { get; set; }
    }
}
