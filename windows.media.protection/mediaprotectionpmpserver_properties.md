---
-api-id: P:Windows.Media.Protection.MediaProtectionPMPServer.Properties
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IPropertySet Properties { get; }
-->

# Windows.Media.Protection.MediaProtectionPMPServer.Properties

## -description
Gets the property set for the [MediaProtectionPMPServer](mediaprotectionpmpserver.md).

## -property-value
The property set for the [MediaProtectionPMPServer](mediaprotectionpmpserver.md).

## -remarks
[MediaProtectionPMPServer](mediaprotectionpmpserver.md) supports the following properties:

<table>
   <tr><th>Property</th><th>Description</th></tr>
   <tr><td>"Windows.Media.Protection.MediaProtectionSystemId"</td><td>A GUID representing the DRM system your app will use. This allows the system to determine if hardware DRM is supported on the device.</td></tr>
   <tr><td>Windows.Media.Protection.UseSoftwareProtectionLayer</td><td>Setting this to true tells the system to use software DRM even if hardware DRM is available on the current device.</td></tr>
</table>

## -examples

## -see-also
