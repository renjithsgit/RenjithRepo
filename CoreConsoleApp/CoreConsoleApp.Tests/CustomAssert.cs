using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreConsoleApp.Tests
{
    public static class CustomAssert
    {
        public static void IsInRange(this Assert assert,
            int actual,
                  int minValue,
                  int maxValue)
        {
            if(actual < minValue || actual > maxValue)
            {
                throw new AssertFailedException("not in range");
            }
        }
    }
}
