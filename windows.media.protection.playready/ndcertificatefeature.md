---
-api-id: T:Windows.Media.Protection.PlayReady.NDCertificateFeature
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Media.Protection.PlayReady.NDCertificateFeature : int
-->

# NDCertificateFeature

## -description
Indicates the PlayReady-ND feature to which the certificate controls access.

## -enum-fields
### -field Transmitter:1
Entity implements transmitter functionality.

### -field Receiver:2
Entity implements receiver functionality.

### -field SharedCertificate:3
Entity shares receiver key across multiple devices.

### -field SecureClock:4
Device implements SecureClock.

### -field AntiRollBackClock:5
Device implements anti-rollback clock.

### -field CRLS:9
Entity supports certificate revocation lists.

### -field PlayReady3Features:13
Entity supports PlayReady version 3.x features such as per-stream keys.


## -remarks

## -examples

## -see-also