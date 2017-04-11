// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Dns.Fluent
{
    using DnsZone.Definition;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core.CollectionActions;
    using ResourceManager.Fluent.Core;

    /// <summary>
    /// Entry point to DNS zone management API in Azure.
    /// </summary>
    public interface IDnsZones  :
        ISupportsCreating<DnsZone.Definition.IBlank>,
        ISupportsListing<Microsoft.Azure.Management.Dns.Fluent.IDnsZone>,
        ISupportsListingByResourceGroup<Microsoft.Azure.Management.Dns.Fluent.IDnsZone>,
        ISupportsGettingByResourceGroup<Microsoft.Azure.Management.Dns.Fluent.IDnsZone>,
        ISupportsGettingById<Microsoft.Azure.Management.Dns.Fluent.IDnsZone>,
        ISupportsDeletingById,
        ISupportsDeletingByResourceGroup,
        ISupportsBatchCreation<Microsoft.Azure.Management.Dns.Fluent.IDnsZone>,
        ISupportsBatchDeletion,
        IHasManager<IDnsZoneManager>,
        IHasInner<IZonesOperations>
    {
    }
}