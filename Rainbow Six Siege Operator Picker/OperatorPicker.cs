using System;
using System.Collections.Generic;
using System.Linq;

namespace Rainbow_Six_Siege_Operator_Picker
{
    internal class OperatorPicker
    {
        private readonly Dictionary<string, int> attackerPickCounts = new Dictionary<string, int>();
        private readonly Dictionary<string, int> defenderPickCounts = new Dictionary<string, int>();
        private string lastAttacker;
        private string lastDefender;
        private readonly Random rng = new Random();

        // Returns the selected operator name, or null if the list is empty.
        public string Pick(List<string> list, string type)
        {
            if (list.Count == 0)
                return null;

            var pickCounts = type == "Attacker" ? attackerPickCounts : defenderPickCounts;
            string lastPick = type == "Attacker" ? lastAttacker : lastDefender;

            foreach (var op in list)
                if (!pickCounts.ContainsKey(op))
                    pickCounts[op] = 0;

            if (pickCounts.Values.All(v => v > 0))
                foreach (var key in pickCounts.Keys.ToList())
                    pickCounts[key] = 0;

            var available = list.Where(op => pickCounts[op] == 0).ToList();
            if (available.Count == 0)
                available = new List<string>(list);

            string selected;
            do
            {
                selected = available[rng.Next(available.Count)];
            }
            while (available.Count > 1 && selected == lastPick);

            pickCounts[selected]++;

            if (type == "Attacker")
                lastAttacker = selected;
            else
                lastDefender = selected;

            return selected;
        }

        public void Reset()
        {
            attackerPickCounts.Clear();
            defenderPickCounts.Clear();
            lastAttacker = null;
            lastDefender = null;
        }
    }
}
