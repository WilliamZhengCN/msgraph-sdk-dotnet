// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph
{
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// Interface for the base client.
    /// </summary>
    public interface IBaseClient
    {
        /// <summary>
        /// Gets the <see cref="IAuthenticationProvider"/> for authenticating HTTP requests.
        /// </summary>
        IAuthenticationProvider AuthenticationProvider { get; }

        /// <summary>
        /// Gets the base URL for requests of the client.
        /// </summary>
        string BaseUrl { get; }

        /// <summary>
        /// Gets the <see cref="IHttpProvider"/> for sending HTTP requests.
        /// </summary>
        IHttpProvider HttpProvider { get; }

        /// <summary>
        /// Gets or Sets the <see cref="IAuthenticationProvider"/> for authenticating a single HTTP requests. 
        /// </summary>
        Func<string, IAuthenticationProvider> PerRequestAuthProvider { get; set; }
    }
}
