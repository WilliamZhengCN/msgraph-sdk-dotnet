// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type ChannelMembersCollectionRequestBuilder.
    /// </summary>
    public partial class ChannelMembersCollectionRequestBuilder : BaseRequestBuilder, IChannelMembersCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new ChannelMembersCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ChannelMembersCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IChannelMembersCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IChannelMembersCollectionRequest Request(IEnumerable<Option> options)
        {
            return new ChannelMembersCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IConversationMemberRequestBuilder"/> for the specified ChannelConversationMember.
        /// </summary>
        /// <param name="id">The ID for the ChannelConversationMember.</param>
        /// <returns>The <see cref="IConversationMemberRequestBuilder"/>.</returns>
        public IConversationMemberRequestBuilder this[string id]
        {
            get
            {
                return new ConversationMemberRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
