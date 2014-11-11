﻿// ==============================================================================================================
// Microsoft patterns & practices
// CQRS Journey project
// ==============================================================================================================
// ©2012 Microsoft. All rights reserved. Certain content used with permission from contributors
// http://go.microsoft.com/fwlink/p/?LinkID=258575
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance 
// with the License. You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software distributed under the License is 
// distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. 
// See the License for the specific language governing permissions and limitations under the License.
// ==============================================================================================================

namespace Registration.ReadModel
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public class PricedOrder
    {
        private IList<PricedOrderLine> _lines = new List<PricedOrderLine>();

        public Guid OrderId { get; set; }
        public Guid? AssignmentsId { get; set; }
        public decimal Total { get; set; }
        public int OrderVersion { get; set; }
        public bool IsFreeOfCharge { get; set; }
        public DateTime? ReservationExpirationDate { get; set; }

        public void SetLines(IList<PricedOrderLine> lines)
        {
            _lines = lines;
        }
        public IEnumerable<PricedOrderLine> GetLines()
        {
            return _lines;
        }
    }

    public class PricedOrderLine
    {
        public Guid OrderId { get; set; }
        public int Position { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal LineTotal { get; set; }
    }
}
