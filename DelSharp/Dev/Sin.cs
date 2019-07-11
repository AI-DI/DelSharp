using System;
using System.Collections.Generic;

namespace DelSharp.Dev
{
    public class Sin : Function
    {
        protected override float Evaluate(List<float> values)
        {
            return (float) Math.Sin((double) values[0]);
        }

        protected override float Derive(int index)
        {
            return (float) Math.Cos(Differentiables[index].Value);
        }
    }
}