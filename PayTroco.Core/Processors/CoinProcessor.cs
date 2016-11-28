using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayTroco.Core.Processors {
    internal class CoinProcessor : AbstractProcessor{

        public CoinProcessor() {

        }

        internal override int[] GetAvailableValues() {
            int[] coins = { 100, 50, 25, 10, 5, 1 };
            return coins;
        }

        internal override string GetName() {

            string name = "Coin";

            return name;
        }
    }
}
