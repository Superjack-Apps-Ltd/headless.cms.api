﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Superjack.MultiSites.Api.DataAccess
{
  public class PageField
  {
    [Column("Id")]
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Required]
    public long Id { get; set; }

    [Column("Uuid")]
    [Required]
    public Guid Uuid { get; set; }

    [Column("PageBlockId")]
    [Required]
    public long PageBlockId { get; set; }

    [Column("FieldId")]
    public long? FieldId { get; set; }

    [Column("Title")]
    [Required]
    public string Title { get; set; }

    [Column("DataType")]
    [Required]
    public string DataType { get; set; }

    [Column("SortOrder")]
    [Required]
    public long SortOrder { get; set; }

    [Column("Value")]
    public string Value { get; set; }
  }
}

