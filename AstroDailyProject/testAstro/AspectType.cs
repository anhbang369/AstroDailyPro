﻿using System;
using System.Collections.Generic;

#nullable disable

namespace AstroDailyProject.testAstro
{
    public partial class AspectType
    {
        public AspectType()
        {
            Aspects = new HashSet<Aspect>();
        }

        public int Id { get; set; }
        public double? Angle { get; set; }

        public virtual ICollection<Aspect> Aspects { get; set; }
    }
}
