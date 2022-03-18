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
The SessionKey property is only used with a [StreamSocket](streamsocket.md) object created by proximity devices when initiated by tapping. The SessionKey property for a tapping device may contain an array with a private shared secret. A private shared secret is not required by a tapping device, so this property can be null.

For proximity devices initiated by tapping, the SessionKey property can be passed to Crypto runtime classes to handle encryption. For more information, see [Supporting proximity and tapping](/previous-versions/windows/apps/hh465229(v=win.10)), the [Windows.Security.Cryptography.Core.SymmetricKeyAlgorithmProvider](../windows.security.cryptography.core/symmetrickeyalgorithmprovider.md) class, and related classes.

For other [StreamSocket](streamsocket.md) objects not initiated by tapping, the SessionKey property is always null.

## -examples

## -see-also
[How to use advanced socket controls](/previous-versions/windows/apps/jj150598(v=win.10)), [Supporting proximity and tapping](/previous-versions/windows/apps/hh465229(v=win.10)), [StreamSocket](streamsocket.md), [Windows.Networking.Proximity.PeerFinder](../windows.networking.proximity/peerfinder.md), [Windows.Security.Cryptography.Core.SymmetricKeyAlgorithmProvider](../windows.security.cryptography.core/symmetrickeyalgorithmprovider.md)

## -capabilities
ID_CAP_NETWORKING [Windows Phone]
