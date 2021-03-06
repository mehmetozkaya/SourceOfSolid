﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontDesk.SharedKernel.Interfaces
{
    public interface IHandle<T> where T : IDomainEvent
    {
        void Handle(T args);
    }
}
