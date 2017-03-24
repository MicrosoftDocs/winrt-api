---
-api-id: P:Windows.Networking.Connectivity.IPInformation.PrefixLength
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Foundation.IReference<byte> PrefixLength { get; }
-->

# Windows.Networking.Connectivity.IPInformation.PrefixLength

## -description
Retrieves the length of the prefix, or network part of the IP address.

## -property-value
The length, in bits, of the prefix or network part.

## -remarks
For a unicast IPv4 address, any value greater than 32 is an illegal value. For a unicast IPv6 address, any value greater than 128 is an illegal value. A value of 255 is commonly used to represent an illegal value.

## -examples

## -see-also
[IReference(Byte)](../windows.foundation/ireference_1.md)