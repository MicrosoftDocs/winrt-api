---
-api-id: P:Windows.Media.Protection.PlayReady.PlayReadyStatics.InputTrustAuthorityToCreate
-api-type: winrt property
---

<!-- Property syntax
public string InputTrustAuthorityToCreate { get; }
-->

# Windows.Media.Protection.PlayReady.PlayReadyStatics.InputTrustAuthorityToCreate

## -description
Gets the PlayReady Trusted Input activation string.

## -property-value
The PlayReady Trusted Input activation string. This string is used by the Media Protection Manager to tell the media source which Input Trust Authority (ITA) to create.

## -remarks
Previous releases of the PlayReady API required callers to hard-code a well-known string and [GUID](/windows/win32/api/guiddef/ns-guiddef-guid) in their code. These APIs provide those values to the caller so they can request them rather than hard-coding them.

In the [MediaProtectionManager.Properties](/uwp/api/windows.media.protection.mediaprotectionmanager.properties) property (a [PropertySet](/uwp/api/windows.foundation.collections.propertyset) object), the "Windows.Media.Protection.MediaProtectionSystemIdMapping" string maps to another **PropertySet**. This in turn will typically have the string "Windows.Media.Protection.PlayReady.PlayReadyStatics.MediaProtectionSystemId" map to **Windows.Media.Protection.PlayReady.PlayReadyStatics.InputTrustAuthorityToCreate**.

[!code-csharp[SnippetSetUpMediaProtectionManager](../windows.media.protection.playready/code/PlayReadyStatics/csharp/MainPage.xaml.cs#SnippetSetUpMediaProtectionManager)]

## -examples

## -see-also
