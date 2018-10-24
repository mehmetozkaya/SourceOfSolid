﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontDesk.SharedKernel
{
    public class Guard
    {
        public static void ForLessEqualZero(int value, string parameterName)
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException(parameterName);
            }
        }

        public static void ForPrecedesDate(DateTime value, DateTime dateToPrecede, string parameterName)
        {
            if (value >= dateToPrecede)
            {
                throw new ArgumentOutOfRangeException(parameterName);
            }
        }

        public static void ForNullOrEmpty(string value, string parameterName)
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentOutOfRangeException(parameterName);
            }
        }

        public static void ForNullOrEmpty(object value, string parameterName)
        {
            if (null == value)
            {
                throw new ArgumentOutOfRangeException(parameterName);
            }
        }
    }
}
