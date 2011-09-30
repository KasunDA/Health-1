﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Health.Core.Entities.Virtual;

namespace Health.Site.Models.Metadata
{
    public class WeekMetadata
    {
        [Required]
        [DisplayName("Четность недели")]
        public ParityOfWeek Parity { get; set; }

        [Range(0, 6)]
        [Required(ErrorMessage = "чцавыаыва")]
        [DisplayName("Номер недели в месяце")]
        public virtual int InMonth { get; set; }
    }

    public class WeekValidationMetadata
    {
        [Required(ErrorMessage = "бла бла бла")]
        public int InMonth { get; set; }
    }
}