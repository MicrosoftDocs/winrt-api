---
-api-id: P:Windows.Media.Protection.PlayReady.PlayReadyStatics.ProtectionSystemId
-api-type: winrt property
---

<!-- Property syntax
public System.Guid ProtectionSystemId { get; }
-->

# Windows.Media.Protection.PlayReady.PlayReadyStatics.ProtectionSystemId

## -description
Gets the PlayReady content protection system ID inside a PSSH box.

## -property-value
Specifies the PlayReady content protection system ID inside a PSSH box. This parameter is sensitive to the underlying platform's endianness. Carefully test your app on all platforms you intend to support to ensure that correct endianness is used on each platform.

## -remarks
Previous releases of the PlayReady API required callers to hard-code a well-known string and [GUID](/windows/win32/api/guiddef/ns-guiddef-guid) in their code. These APIs provide those values to the caller so they can request them rather than hard-coding them.


In the [MediaProtectionManager.Properties](/uwp/api/windows.media.protection.mediaprotectionmanager.properties) property (a [PropertySet](/uwp/api/windows.foundation.collections.propertyset) object), the "Windows.Media.Protection.MediaProtectionContainerGuid" string maps to a GUID, which will typically be the following string: ```csharp
"{" +  Windows.Media.Protection.PlayReady.PlayReadyStatics.ProtectionSystemId.ToString().ToUpper() + "}"
```

## -examples


## -see-also
