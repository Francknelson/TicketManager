﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketManager.Models
{
    public abstract class Base
    {
        public DateTime? created_at {  get; set; }
        public DateTime? updated_at { get; set; }

    }
}
