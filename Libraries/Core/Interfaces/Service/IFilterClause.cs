﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Service
{
    public interface IFilterClause
    {
        string FilterName { get; }

        string FilterValue { get; }
    }
}
