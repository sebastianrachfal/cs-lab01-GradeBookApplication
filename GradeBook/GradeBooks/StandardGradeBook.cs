﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(String name, bool weighted) : base(name, weighted)
        {
            Type = Enums.GradeBookType.Standard;
        }
    }
}
