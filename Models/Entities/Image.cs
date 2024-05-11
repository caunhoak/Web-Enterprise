﻿using System.ComponentModel.DataAnnotations.Schema;
using WebEnterprise.Models.Common;

namespace WebEnterprise.Models.Entities
{
    public class Image : EntityBase
    {
        public string FilePath { get; set; }
        public int ContributionId { get; set; }
        [ForeignKey("ContributionId")]
        public Contribution Contribution { get; set; }
    }
}
