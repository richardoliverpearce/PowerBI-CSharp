// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// WidelySharedArtifacts operations.
    /// </summary>
    public partial interface IWidelySharedArtifacts
    {
        /// <summary>
        /// Returns a list of artifacts shared to the whole organization
        /// through links.
        /// </summary>
        /// <remarks>
        ///
        /// ## Permissions
        ///
        /// - The user must have administrator rights (such as Office 365
        /// Global Administrator or Power BI Service Administrator) or
        /// authenticate using a service principal.
        /// - Delegated permissions are supported.
        ///
        /// ## Required scope
        ///
        /// Tenant.Read.All or Tenant.ReadWrite.All
        ///
        /// ## Limitations
        ///
        /// Maximum 200 requests per hour.
        ///
        /// ######
        ///
        /// </remarks>
        /// <param name='continuationToken'>
        /// Token required to get the next chunk of the result set
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<ArtifactAccessResponse>> LinksSharedToWholeOrganizationWithHttpMessagesAsync(string continuationToken = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of artifacts shared through published to web.
        /// </summary>
        /// <remarks>
        ///
        /// ## Permissions
        ///
        /// - The user must have administrator rights (such as Office 365
        /// Global Administrator or Power BI Service Administrator) or
        /// authenticate using a service principal.
        /// - Delegated permissions are supported.
        ///
        /// ## Required scope
        ///
        /// Tenant.Read.All or Tenant.ReadWrite.All
        ///
        /// ## Limitations
        ///
        /// Maximum 200 requests per hour.
        ///
        /// ######
        ///
        /// </remarks>
        /// <param name='continuationToken'>
        /// Token required to get the next chunk of the result set
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<ArtifactAccessResponse>> PublishedToWebWithHttpMessagesAsync(string continuationToken = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
