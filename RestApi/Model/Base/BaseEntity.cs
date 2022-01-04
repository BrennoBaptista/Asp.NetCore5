﻿using System.ComponentModel.DataAnnotations.Schema;

namespace RestApi.Model.Base
{
    public class BaseEntity
    {
        [Column("id")]
        public long Id { get; set; }
    }
}
