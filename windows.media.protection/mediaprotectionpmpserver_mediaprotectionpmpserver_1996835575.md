---
-api-id: M:Windows.Media.Protection.MediaProtectionPMPServer.#ctor(Windows.Foundation.Collections.IPropertySet)
-api-type: winrt method
---

<!-- Method syntax
public MediaProtectionPMPServer(Windows.Foundation.Collections.IPropertySet pProperties)
-->

# Windows.Media.Protection.MediaProtectionPMPServer.MediaProtectionPMPServer

## -description
Initializes a new instance of the [MediaProtectionPMPServer](mediaprotectionpmpserver.md) class with the specified properties.

## -parameters
### -param pProperties
The set of properties used to initialize the server.

## -remarks
[MediaProtectionPMPServer](mediaprotectionpmpserver.md) supports the following properties:

<table>
   <tr><th>Property</th><th>Description</th></tr>
   <tr><td>"Windows.Media.Protection.MediaProtectionSystemId"</td><td>A GUID representing the DRM system your app will use. This allows the system to determine if hardware DRM is supported on the device.</td></tr>
   <tr><td>Windows.Media.Protection.UseSoftwareProtectionLayer</td><td>Setting this to true tells the system to use software DRM even if hardware DRM is available on the current device.</td></tr>
</table>

## -examples

## -see-also
