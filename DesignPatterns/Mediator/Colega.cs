﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public abstract class Colega
    {
        protected Mediator mediator;
        public Colega(Mediator mediator)
        {
            this.mediator = mediator;
        }
    }
}
