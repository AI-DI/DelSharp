using System.Collections.Generic;
using System.Linq;

namespace DelSharp.Dev
{
    public class Sum : Function
    {
        protected override float Evaluate(List<float> values)
        {
            return values.Sum();
        }

        protected override float Derive(int index)
        {
            return 1.0f;
        }
    }
}