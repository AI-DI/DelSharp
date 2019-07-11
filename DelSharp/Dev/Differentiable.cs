using System.Collections.Generic;

namespace DelSharp.Dev
{
    public abstract class Differentiable
    {
        public abstract float Value { get; protected set;}
        public abstract float Backward(Differentiable differentiable);
        public abstract Differentiable Forward();
        public abstract Differentiable Forward(List<Differentiable> differentiables);
    }
}