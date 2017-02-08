---
-api-id: M:Windows.Media.Protection.PlayReady.IPlayReadyLicense.GetKIDAtChainDepth(System.UInt32)
-api-type: winrt method
---

<!-- Method syntax
public System.Guid GetKIDAtChainDepth(System.UInt32 chainDepth)
-->

# Windows.Media.Protection.PlayReady.IPlayReadyLicense.GetKIDAtChainDepth

## -description
Gets the key identifier (KID) of the license at the specified chain depth.

## -parameters
### -param chainDepth
The depth of the license in the chain for which to retrieve the KID. This value is a 0-based index.

## -returns
The KID of the license. This return value is sensitive to the underlying platform's endianness. Carefully test your app on all platforms you intend to support to ensure that correct endianness is used on each platform.

## -remarks
The *chainDepth* parameter must be between the value of 0 and ([IPlayReadyLicense.ChainDepth](iplayreadylicense_chaindepth.md) - 1).

## -examples

## -see-also
