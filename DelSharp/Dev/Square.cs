using System;
using System.Collections.Generic;
using System.Linq;

namespace DelSharp.Dev
{
    public class Square : Function
    {
        protected override float Evaluate(List<float> values)
        {
            return (float) Math.Pow(values[0], 2);
        }

        protected override float Derive(int index)
        {
            return 2 * Differentiables[index].Value;
        }
    }
}