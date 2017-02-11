---
-api-id: P:Windows.Networking.Sockets.StreamSocketInformation.SessionKey
-api-type: winrt property
---

<!-- Property syntax
public Windows.Storage.Streams.IBuffer SessionKey { get; }
-->

# Windows.Networking.Sockets.StreamSocketInformation.SessionKey

## -description
Get a byte array that represents the private shared secret exchanged by proximity devices.

## -property-value
A byte array that represents the private shared secret exchanged by proximity devices.

## -remarks
The [SessionKey](streamsocketinformation_sessionkey.md) property is only used with a [StreamSocket](streamsocket.md) object created by proximity devices when initiated by tapping. The [SessionKey](streamsocketinformation_sessionkey.md) property for a tapping device may contain an array with a private shared secret. A private shared secret is not required by a tapping device, so this property can be null.

For proximity devices initiated by tapping, the [SessionKey](streamsocketinformation_sessionkey.md) property can be passed to Crypto runtime classes to handle encryption. For more information, see [Supporting proximity and tapping](http://msdn.microsoft.com/library/84a30dcf-ef14-4a93-9e7c-7a3de867d46b), the [Windows.Security.Cryptography.Core.SymmetricKeyAlgorithmProvider](../windows.security.cryptography.core/symmetrickeyalgorithmprovider.md) class, and related classes.

For other [StreamSocket](streamsocket.md) objects not initiated by tapping, the [SessionKey](streamsocketinformation_sessionkey.md) property is always null.

## -examples

## -see-also
[How to use advanced socket controls ](http://msdn.microsoft.com/library/2e1071d8-a1c7-44c0-b93a-31a701d431c4), [How to use advanced socket controls ](http://msdn.microsoft.com/library/f2c5be73-3461-452e-a38f-d2ddef9b5682), [Supporting proximity and tapping](http://msdn.microsoft.com/library/84a30dcf-ef14-4a93-9e7c-7a3de867d46b), [StreamSocket](streamsocket.md), [Windows.Networking.Proximity.PeerFinder](../windows.networking.proximity/peerfinder.md), [Windows.Security.Cryptography.Core.SymmetricKeyAlgorithmProvider](../windows.security.cryptography.core/symmetrickeyalgorithmprovider.md)

## -capabilities
ID_CAP_NETWORKING [Windows Phone]