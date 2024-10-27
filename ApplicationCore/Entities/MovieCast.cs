﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    [Table("MovieCasts")]
    [PrimaryKey(nameof(CastId), nameof(MovieId), nameof(Character))]
    public class MovieCast
    {
        public int CastId { get; set; }
        public Cast Cast { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(450)")]
        public string Character {  get; set; }

    }
}
