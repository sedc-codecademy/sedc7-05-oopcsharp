using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigGame.Models
{
    class Dice
    {
        public enum Colors {White, Red, Blue };
        public enum Sizes {Low, Medium, High};
        public Dice(Random rnd)
        {
            this.rnd = rnd;
            this.Value = 0;
            this.Color = Colors.White;
            this.Size = Sizes.Medium;
        }
        private Random rnd;
        public Colors Color { get; set; }
        public Sizes Size { get; set; }
        public int Value { get; set; }
        public void Roll()
        {
            this.Clear();
            this.Value = rnd.Next(1, 7);
        }
        private void Clear()
        {
            this.Value = 0;
        }
    }
}
