namespace umf_lab2.Models;

using System;

public class Func
{
   public readonly Func<double, double> RightPart = x => 2 * x - 3;
   public readonly Func<double, double> UStar = x => x;
}