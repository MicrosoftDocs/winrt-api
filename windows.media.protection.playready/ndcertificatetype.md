---
-api-id: T:Windows.Media.Protection.PlayReady.NDCertificateType
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Media.Protection.PlayReady.NDCertificateType : int
-->

# NDCertificateType

## -description
Indicates the type and purpose of a PlayReady-ND transmitter license.

## -enum-fields
### -field Unknown:0
An unknown certificate type. Apps should never use this value.

### -field PC:1
A leaf level certificate used by the PC client.

### -field Device:2
A leaf level certificate used by a device.

### -field Domain:3
A leaf level certificate used by a PC or a device when a member of a domain.

### -field Issuer:4
Can be an issuer of certificates for either an issuer or a leaf certificate.

### -field CrlSigner:5
A leaf level certificate used to sign CRLs issued by Microsoft.

### -field Service:6
A leaf level certificate used by services such as Secure Clock. Reserved for future use.

### -field Silverlight:7
A leaf level certificate for a Silverlight client.

### -field Application:8
A leaf level certificate for a PlayReady client.

### -field Metering:9
A leaf level certificate used by digital rights management clients to encrypt metering data sent to a PlayReady SDK server.

### -field KeyFileSigner:10
A leaf level certificate used by the cryptography server to sign the key file.

### -field Server:11
A leaf level certificate used by the PlayReady server.

### -field LicenseSigner:12
A certificate used by a license signer.


## -remarks

## -examples

## -see-also