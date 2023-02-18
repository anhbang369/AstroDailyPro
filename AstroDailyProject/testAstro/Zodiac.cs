﻿using System;
using System.Collections.Generic;

#nullable disable

namespace AstroDailyProject.testAstro
{
    public partial class Zodiac
    {
        public Zodiac()
        {
            Explanations = new HashSet<Explanation>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Explanation> Explanations { get; set; }
    }
}
