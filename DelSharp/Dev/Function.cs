using System;
using System.Collections.Generic;
using System.Linq;

namespace DelSharp.Dev
{
    public abstract class Function : Differentiable
    {
        public override float Value { get; protected set; }
        protected List<Differentiable> Differentiables;

        private float _totalDerivative;
        
        private bool _isEvaluated;
        private bool _isDerived;

        protected abstract float Evaluate(List<float> values);
        protected abstract float Derive(int index);


        public override Differentiable Forward(List<Differentiable> differentiables)
        {
            Differentiables = differentiables;
            Value = Evaluate(differentiables.Select(value => value.Value).ToList());
            _isEvaluated = true;
            return this;
        }
        public override Differentiable Forward()
        {
            throw new ArgumentException();
        }
        
        public override float Backward(Differentiable differentiable)
        {
            if (!_isEvaluated) throw new Exception("!_isEvaluated");
            
            if (!_isDerived)
                _totalDerivative = Differentiables.Select((value, index) => Derive(index) * value.Backward(differentiable)).Sum();

            _isDerived = true;
            return _totalDerivative;
        }

    }
}