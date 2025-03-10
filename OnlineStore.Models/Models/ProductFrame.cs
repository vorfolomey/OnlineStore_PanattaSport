﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace OnlineStore.Data.Models
{
    public partial class ProductFrame
    {
        [Key]
        public int ProductId { get; set; }
        [Key]
        public int FrameId { get; set; }

        [ForeignKey(nameof(FrameId))]
        [InverseProperty("ProductFrame")]
        public virtual Frame Frame { get; set; }
        [ForeignKey(nameof(ProductId))]
        [InverseProperty("ProductFrame")]
        public virtual Product Product { get; set; }
    }
}
