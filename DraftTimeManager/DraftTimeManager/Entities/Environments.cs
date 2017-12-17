﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DraftTimeManager.Entities
{
    [Table("Environments")]
    public class Environments
    {
        [PrimaryKey, AutoIncrement, Column("Env_Id")]
        public int Env_Id { get; set; }

        [NotNull, Column("Env_Name")]
        public string Env_Name { get; set; }

        [NotNull, Column("Picks")]
        public int Picks { get; set; }
    }
}
