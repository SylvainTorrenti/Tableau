using System;

class Solution
{
    public static double ClosestToZero(double[] ts)
    {
        if (ts.Length == 0) return 0;
        var closest = ts[0];
        foreach (double d in ts)
        {
            double abs = Math.Abs(d);
            double absClosest = Math.Abs(closest);
            if (abs < absClosest)
            {
                closest = d;
            }
            else if (abs == absClosest && closest < 0)
            {
                closest = d;
            }
        }

        return closest;
    }
}