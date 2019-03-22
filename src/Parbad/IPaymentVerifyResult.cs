// Copyright (c) Parbad. All rights reserved.
// Licensed under the GNU GENERAL PUBLIC License, Version 3.0. See License.txt in the project root for license information.

namespace Parbad
{
    /// <summary>
    /// Describes the result of the Verify operation.
    /// </summary>
    public interface IPaymentVerifyResult : IPaymentResult
    {
        /// <summary>
        /// Gets the transaction code from the gateway.
        /// </summary>
        string TransactionCode { get; }
    }
}
