---
-api-id: M:Windows.Media.Protection.PlayReady.NDLicenseFetchDescriptor.#ctor(Windows.Media.Protection.PlayReady.NDContentIDType,System.Byte[],Windows.Media.Protection.PlayReady.INDCustomData)
-api-type: winrt method
---

<!-- Method syntax
public NDLicenseFetchDescriptor(Windows.Media.Protection.PlayReady.NDContentIDType contentIDType, System.Byte[] contentIDBytes, Windows.Media.Protection.PlayReady.INDCustomData licenseFetchChallengeCustomData)
-->

# Windows.Media.Protection.PlayReady.NDLicenseFetchDescriptor.NDLicenseFetchDescriptor

## -description
Creates a new instance of the [NDLicenseFetchDescriptor](ndlicensefetchdescriptor.md) class.

## -parameters
### -param contentIDType
The type of the content identifier.

### -param contentIDBytes
The content identifier.

### -param licenseFetchChallengeCustomData
The license fetch challenge custom data.

## -remarks
If the *NDContentIDType* parameter is equal to **KeyID**, the *contentIDBytes* parameter must be exactly 16 bytes in size.

## -examples

## -see-also
