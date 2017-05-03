---
-api-id: P:Windows.Networking.NetworkOperators.ProvisionFromXmlDocumentResults.ProvisionResultsXml
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public string ProvisionResultsXml { get; }
-->

# Windows.Networking.NetworkOperators.ProvisionFromXmlDocumentResults.ProvisionResultsXml

## -description
Indicates which elements in the provisioning profile could not be successfully provisioned.

> [!NOTE]
> This functionality is only available to mobile operator apps and Windows Store app given privileged access by mobile network operators.

For permission to use this API, please reach out to [Network Operators API Permissions](mailto:netopperm@microsoft.com).

For technical help with this API, please reach out to [Network Operators API Help](mailto:netophelp@microsoft.com)

## -property-value
An instance of [ResultsSchema](XREF:TODO:ResultsSchema.Schema_Root) that indicates which elements in the provisioning profile could not be successfully provisioned.

## -remarks
Calling [ProvisionResultsXml](provisionfromxmldocumentresults_provisionresultsxml.md) when no provisioning file has been submitted will result in an error. When the file was submitted, but not processed due to signature issues, only the [Signature](XREF:TODO:ResultsSchema.element_Signature) element of [ResultsSchema](XREF:TODO:ResultsSchema.Schema_Root) will be present. If [ProvisionFromXmlDocumentAsync](provisioningagent_provisionfromxmldocumentasync.md) returned an error, [ResultsSchema](XREF:TODO:ResultsSchema.Schema_Root) will indicate “Failure” at the file level in the [CarrierProvisioningResult](XREF:TODO:ResultsSchema.element_CarrierProvisioningResult) element, with the error code specified. If the file was valid, but errors occurred while acting on it, [ResultsSchema](XREF:TODO:ResultsSchema.Schema_Root) will coalesce errors, listing the error code at the highest level at which it applies to all sections underneath. If errors are coalesced to a higher level, the lower levels are not included. For example, if all WLAN profiles failed for the same reason, this reason will be shown as an attribute of the [WLANProfiles](XREF:TODO:ResultsSchema.element_WLANProfiles) node. If different profiles failed for different reasons, then each profile will be enumerated and indicate success or failure with the error code specified. In cases where multiple adapters are present, a success on any adapter should be represented as success, even if the profile failed to apply to other adapters. If a profile failed to apply to all adapters, [ResultsSchema](XREF:TODO:ResultsSchema.Schema_Root) will contain at least one of the error codes, but will not enumerate all errors which occurred on various adapters.

## -examples

## -see-also
