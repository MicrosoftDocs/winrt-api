---
-api-id: T:Windows.Management.Update.WindowsSoftwareUpdateProviderTrustState
-api-type: winrt enum
---

# Windows.Management.Update.WindowsSoftwareUpdateProviderTrustState

<!--
public enum WindowsSoftwareUpdateProviderTrustState
-->


## -description

Defines constants that specify the code-signing trust state of a [WindowsSoftwareUpdateProvider](./windowssoftwareupdateprovider.md) or one of its payload files.

## -enum-fields

### -field SignedTrusted: 0
The content is digitally signed and the signature chains to a trusted certificate authority on the device.

### -field SignedUntrusted: 1
The content is digitally signed, but the signature does not chain to a trusted certificate authority on the device.

### -field Unsigned: 2
The content is not digitally signed.

## -remarks

Provider registration requires trusted, signed content. For the signing and catalog requirements, see the provider authoring guide in the [windows-uop](https://github.com/microsoft/windows-uop) repository.

## -see-also

[WindowsSoftwareUpdateProvider](./windowssoftwareupdateprovider.md), [WindowsSoftwareUpdateProviderPayloadFileInfo](./windowssoftwareupdateproviderpayloadfileinfo.md)

## -examples

