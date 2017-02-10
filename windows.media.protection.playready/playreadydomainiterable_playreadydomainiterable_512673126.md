---
-api-id: M:Windows.Media.Protection.PlayReady.PlayReadyDomainIterable.#ctor(System.Guid)
-api-type: winrt method
---

<!-- Method syntax
public PlayReadyDomainIterable(System.Guid domainAccountId)
-->

# Windows.Media.Protection.PlayReady.PlayReadyDomainIterable.PlayReadyDomainIterable

## -description
Initializes a new instance of the [PlayReadyDomainIterable](playreadydomainiterable.md) class using the domain account identifier.

## -parameters
### -param domainAccountId
The domain account identifier.

## -remarks
The *domainAccountId* parameter is optional; if the value specified is **GUID_NULL**, all domains to which this client is joined will be enumerated.

The *domainAccountId* parameter is sensitive to the underlying platform's endianness. Carefully test your app on all platforms you intend to support to ensure that correct endianness is used on each platform.

## -examples

## -see-also
