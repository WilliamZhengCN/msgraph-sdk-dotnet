// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IWorkbookChartSeriesPointsCollectionRequestBuilder.
    /// </summary>
    public partial interface IWorkbookChartSeriesPointsCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IWorkbookChartSeriesPointsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IWorkbookChartSeriesPointsCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IWorkbookChartPointRequestBuilder"/> for the specified WorkbookChartPoint.
        /// </summary>
        /// <param name="id">The ID for the WorkbookChartPoint.</param>
        /// <returns>The <see cref="IWorkbookChartPointRequestBuilder"/>.</returns>
        IWorkbookChartPointRequestBuilder this[string id] { get; }

        /// <summary>
        /// Gets the request builder for WorkbookChartPointCount.
        /// </summary>
        /// <returns>The <see cref="IWorkbookChartPointCountRequestBuilder"/>.</returns>
        IWorkbookChartPointCountRequestBuilder Count();

        /// <summary>
        /// Gets the request builder for WorkbookChartPointItemAt.
        /// </summary>
        /// <returns>The <see cref="IWorkbookChartPointItemAtRequestBuilder"/>.</returns>
        IWorkbookChartPointItemAtRequestBuilder ItemAt(
            Int32 index);
    }
}
