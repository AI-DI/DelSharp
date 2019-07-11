using System;
using System.Collections.Generic;

namespace DelSharp.Dev
{
    public class Parameter : Differentiable
    {
        public override float Value { get; protected set; }

        public Parameter(float value)
        {
            Value = value;
        }
        
        public override float Backward(Differentiable differentiables)
        {
            return differentiables.Equals(this) ? 1.0f : 0.0f;
        }

        public override Differentiable Forward()
        {
            return this;
        }
        
        public override Differentiable Forward(List<Differentiable> differentiables)
        {
            throw new ArgumentException();
        }
    }
}
