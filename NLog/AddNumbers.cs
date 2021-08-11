using System;
using System.Collections.Generic;
using System.Text;

namespace SessionNLog
{
    public class AddNumbers
    {
        NLog nLog = new NLog(); 

        public int Sum(int a, int b)
        {
            if (a==0 || b==0)
            {
                nLog.LogDebug("Debug Successful : Sum()");
                nLog.LogError("Expecting null values");
                nLog.LogWarn("a or b should not be equal to 0");
            }

            int c = a + b;
            nLog.LogDebug("Debug Successful : Sum()");
            nLog.LogInfo("Sum Method passed, Result" + c);

            return c;
        }
    }
}
