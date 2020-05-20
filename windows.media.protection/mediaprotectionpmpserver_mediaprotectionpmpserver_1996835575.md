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

|Property                   |            Description  |
|---------------------------|-------------------------|
|"Windows.Media.Protection.MediaProtectionSystemId" | A GUID representing the DRM system your app will use. This allows the system to determine if hardware DRM is supported on the device. |
|Windows.Media.Protection.UseSoftwareProtectionLayer | Setting this to true tells the system to use software DRM even if hardware DRM is available on the current device. |
|Windows.Media.Protection.PMPStoreContext | When implementing a Store Content Decryption Module (CDM) object, the Store CDM should look for and make a copy of the [MF_CONTENTDECRYPTIONMODULE_PMPSTORECONTEXT](/windows/win32/medfound/mf-contentdecryptionmodule-pmpstorecontext) property in [IMFContentDecryptionModuleAccess::CreateContentDecryptionModule](/windows/win32/api/mfcontentdecryptionmodule/nf-mfcontentdecryptionmodule-imfcontentdecryptionmoduleaccess-createcontentdecryptionmodule). If the Store CDM object wants to create a **MediaProtectionPMPServer** that will support [CreateObjectByCLSID](/windows/win32/api/mfidl/nf-mfidl-imfpmphost-createobjectbyclsid) for objects defined in the Store CDM binary, they need pass this property. |


## -examples

## -see-also
