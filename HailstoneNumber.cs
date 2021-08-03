using System.Collections.Generic;
using System.Linq;

namespace ThreeXplusOne
{
    public class HailstoneNumber
    {
        public HailstoneNumber(ulong number)
        {
            Number = number;
            NumberSet.Add(this);

            if (!FloorHit())
            {
                var n = new HailstoneNumber(NextNumber());
                NumberSet.AddRange(n.NumberSet);
            }
        }

        public ulong MaxHeight => NumberSet.Max(n => n.Number);
        public int StoppingTime => NumberSet.Count;
        public ulong Number { get; }
        public List<HailstoneNumber> NumberSet { get; } = new();

        private ulong NextNumber() => Number % 2 == 0 ? Number / 2 : Number * 3 + 1;
        private bool FloorHit() => Number == 1;
        public string NumberSetString() => string.Join(@", ", NumberSet.Select(ns => ns.Number));
        
    }
}