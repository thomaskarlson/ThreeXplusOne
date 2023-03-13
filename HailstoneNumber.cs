using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace ThreeXplusOne
{
    public class HailstoneNumber
    {
        public HailstoneNumber(BigInteger number)
        {
            Number = number;
            NumberSet.Add(this);

            if (!FloorHit())
            {
                var n = new HailstoneNumber(NextNumber());
                NumberSet.AddRange(n.NumberSet);
            }
        }

        public BigInteger MaxHeight => NumberSet.Max(n => n.Number);
        public int StoppingTime => NumberSet.Count;
        public BigInteger Number { get; }
        public List<HailstoneNumber> NumberSet { get; } = new();

        private BigInteger NextNumber() => Number % 2 == 0 ? Number / 2 : Number * 3 + 1;
        private bool FloorHit() => Number == 1;
        public string NumberSetString() => string.Join(@", ", NumberSet.Select(ns => ns.Number));
        
    }
}