using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayTroco.Core.Processors {
    internal class CandyProcessor : AbstractProcessor{

        public CandyProcessor() {

        }

        internal override int[] GetAvailableValues() {
            int[] candies = { 3, 1 };
            return candies; 
        }

        internal override string GetName() {
            string name = "Candy";

            return name;
        }
    }
}
