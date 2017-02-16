---
-api-id: P:Windows.Media.Protection.PlayReady.INDRegistrationCompletedEventArgs.TransmitterCertificateAccepted
-api-type: winrt property
---

<!-- Property syntax
public bool TransmitterCertificateAccepted { get;  set; }
-->

# Windows.Media.Protection.PlayReady.INDRegistrationCompletedEventArgs.TransmitterCertificateAccepted

## -description
Gets or sets whether to accept or reject a transmitter's certificate.

## -property-value
The result from verifying the transmitter's certificate. This value is **true** if the receiver accepts the transmitter certificate or **false** if it rejects the certificate.

## -remarks
The receiver must accept or reject the transmitter certificate when the mutual authentication flag is set in [NDStartAsyncOptions](ndstartasyncoptions.md).

## -examples

## -see-also
