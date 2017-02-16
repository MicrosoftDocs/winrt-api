---
-api-id: P:Windows.Media.Protection.PlayReady.IPlayReadyLicense.DomainAccountID
-api-type: winrt property
---

<!-- Property syntax
public System.Guid DomainAccountID { get; }
-->

# Windows.Media.Protection.PlayReady.IPlayReadyLicense.DomainAccountID

## -description
Gets the domain account identifier to which this license is bound.

## -property-value
The domain account identifier. If the license is not domain bound, **GUID_NULL** is returned. This property value is sensitive to the underlying platform's endianness. Carefully test your app on all platforms you intend to support to ensure that correct endianness is used on each platform.

## -remarks

## -examples

## -see-also
