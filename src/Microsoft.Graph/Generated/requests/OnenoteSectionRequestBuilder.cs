// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type OnenoteSectionRequestBuilder.
    /// </summary>
    public partial class OnenoteSectionRequestBuilder : OnenoteEntityHierarchyModelRequestBuilder, IOnenoteSectionRequestBuilder
    {

        /// <summary>
        /// Constructs a new OnenoteSectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public OnenoteSectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IOnenoteSectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IOnenoteSectionRequest Request(IEnumerable<Option> options)
        {
            return new OnenoteSectionRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Pages.
        /// </summary>
        /// <returns>The <see cref="IOnenoteSectionPagesCollectionRequestBuilder"/>.</returns>
        public IOnenoteSectionPagesCollectionRequestBuilder Pages
        {
            get
            {
                return new OnenoteSectionPagesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("pages"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for ParentNotebook.
        /// </summary>
        /// <returns>The <see cref="INotebookRequestBuilder"/>.</returns>
        public INotebookRequestBuilder ParentNotebook
        {
            get
            {
                return new NotebookRequestBuilder(this.AppendSegmentToRequestUrl("parentNotebook"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for ParentSectionGroup.
        /// </summary>
        /// <returns>The <see cref="ISectionGroupRequestBuilder"/>.</returns>
        public ISectionGroupRequestBuilder ParentSectionGroup
        {
            get
            {
                return new SectionGroupRequestBuilder(this.AppendSegmentToRequestUrl("parentSectionGroup"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for OnenoteSectionCopyToNotebook.
        /// </summary>
        /// <returns>The <see cref="IOnenoteSectionCopyToNotebookRequestBuilder"/>.</returns>
        public IOnenoteSectionCopyToNotebookRequestBuilder CopyToNotebook(
            string id = null,
            string groupId = null,
            string renameAs = null,
            string siteCollectionId = null,
            string siteId = null)
        {
            return new OnenoteSectionCopyToNotebookRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.copyToNotebook"),
                this.Client,
                id,
                groupId,
                renameAs,
                siteCollectionId,
                siteId);
        }

        /// <summary>
        /// Gets the request builder for OnenoteSectionCopyToSectionGroup.
        /// </summary>
        /// <returns>The <see cref="IOnenoteSectionCopyToSectionGroupRequestBuilder"/>.</returns>
        public IOnenoteSectionCopyToSectionGroupRequestBuilder CopyToSectionGroup(
            string id = null,
            string groupId = null,
            string renameAs = null,
            string siteCollectionId = null,
            string siteId = null)
        {
            return new OnenoteSectionCopyToSectionGroupRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.copyToSectionGroup"),
                this.Client,
                id,
                groupId,
                renameAs,
                siteCollectionId,
                siteId);
        }
    
    }
}
