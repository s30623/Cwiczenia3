﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia3
{
    public interface IHazardNotifier
    {
        void NotifyHazard(string message, string numer_kontenera);
    }
}
