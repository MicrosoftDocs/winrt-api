---
-api-id: M:Windows.Networking.NetworkOperators.ProvisioningAgent.ProvisionFromXmlDocumentAsync(System.String)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Networking.NetworkOperators.ProvisionFromXmlDocumentResults> ProvisionFromXmlDocumentAsync(System.String provisioningXmlDocument)
-->

# Windows.Networking.NetworkOperators.ProvisioningAgent.ProvisionFromXmlDocumentAsync

## -description
Provisions a device for network connectivity asynchronously, based on the supplied XML document.

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
> 
> If you want to use this API and publish your app to the Microsoft Store, then you'll need special approval. For more information, see the **Restricted capabilities** section in the [App capability declarations](/windows/uwp/packaging/app-capability-declarations#restricted-capabilities) topic. 

## -parameters
### -param provisioningXmlDocument
An instance of [CarrierControlSchema](/uwp/schemas/mobilebroadbandschema/carriercontrolschema/schema-root) that contains the network connectivity provisioning information.

## -returns
An asynchronous handler to start the provisioning attempt and track its completion.

## -remarks
You can retrieve the results of the provisioning attempt using the [ProvisionResultsXml](provisionfromxmldocumentresults_provisionresultsxml.md) method when the provisioning attempt has completed.

ProvisionFromXmlDocumentAsync returns critical errors as HRESULTs that are then translated into exceptions. The most common HRESULTs returned are listed below:<table>
   <tr><th>Name</th><th>HRESULT</th><th>Description</th></tr>
   <tr><td>E_ACCESSDENIED</td><td>0x80070005L</td><td>Caller is an operator app, but attempted to provision a different operator’s profiles</td></tr>
   <tr><td>PROVCORE_E_XML_MALFORMED</td><td>0x82170001</td><td>Provisioning file is not well-formed XML</td></tr>
   <tr><td>PROVCORE_E_XML_INVALID</td><td>0x82170002</td><td>Provisioning file does not conform to schema</td></tr>
   <tr><td>PROVCORE_E_XML_SIGNATURE_INVALID</td><td>0x82170003</td><td>Provisioning file signature is invalid</td></tr>
   <tr><td>PROVCORE_E_XML_SIGNATURE_UNTRUSTED</td><td>0x82170004</td><td>Signing certificate is not chained to a trusted root CA</td></tr>
   <tr><td>PROVCORE_E_XML_DIGEST_INVALID</td><td>0x82170005</td><td>Provisioning file was modified after being signed</td></tr>
   <tr><td>PROVCORE_E_XML_SIGNER_UNTRUSTED</td><td>0x82170006</td><td>User did not approve provisioning from this certificate.</td></tr>
   <tr><td>PROVCORE_E_NO_LEAF_CERT</td><td>0x82170007</td><td>No leaf certificate was included in XML signature</td></tr>
   <tr><td>PROVCORE_E_SIGNING_CERTIFICATE_INVALID_FOR_SIGNING</td><td>0x8217000D</td><td>Signing certificate does not meet requirements (Extended Validation, digital signature usage)</td></tr>
   <tr><td>PROVCORE_E_XML_MISSING_SIGNATURE</td><td>0x8217000E</td><td>XML was not signed (and caller was not a mobile broadband operator app)</td></tr>
</table>

## -examples

## -see-also


## -capabilities
cellularDeviceIdentity, cellularDeviceControl
networkConnectionManagerProvisioning
networkDataPlanProvisioning
