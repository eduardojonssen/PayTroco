using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayTroco.Core.DataContracts {
    public class CalculateChangeRequest : AbstractRequest {

        public CalculateChangeRequest() : base() { }

        public int ProductAmountInCents { get; set; }
        public int InsertedAmountInCents { get; set; }

        protected override void Validate() {

            if (this.ProductAmountInCents < 0) {
                this.AddError("ProductAmountInCents", "ProductAmountInCents cannot be lower than zero");
            }

            if (this.InsertedAmountInCents < 0) {
                this.AddError("InsertedAmountInCents", "InsertedAmountInCents cannot be lower than zero");
            }

            if (this.ProductAmountInCents > this.InsertedAmountInCents) {
                this.AddError("InsertedAmountInCents", "InsertedAmountInCents cannot be lower than ProductAmountInCents");
            }
        }
    }
}
