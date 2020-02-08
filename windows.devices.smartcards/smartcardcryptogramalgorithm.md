---
-api-id: T:Windows.Devices.SmartCards.SmartCardCryptogramAlgorithm
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Devices.SmartCards.SmartCardCryptogramAlgorithm : int
-->

# SmartCardCryptogramAlgorithm

## -description
Defines the cryptogram generation algorithm for a cryptogram placement step.

## -enum-fields
### -field None:0
Do not use any algorithm.

### -field CbcMac:1
Use the cipher block chaining message authentication code (CBC-MAC) algorithm.

### -field Cvc3Umd:2
Use the CVC3-UMD algorithm.

### -field DecimalizedMsd:3
Use the decimalized MSD algorithm.

### -field Cvc3MD:4
Use the CVC3-MD algorithm.

### -field Sha1:5
Use the SHA-1 algorithm.

### -field SignedDynamicApplicationData:6
Use the signed dynamic application data algorithm.

### -field RsaPkcs1:7
Use the Public-Key Cryptography Standards 1 (PKCS) RSA algorithm.

### -field Sha256Hmac:8
Use the SHA-256 HMAC algorithm.

## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1703 | 15063 | Sha256Hmac |

## -examples

## -see-also
[Create an NFC Smart Card app (applies to Windows 10 Mobile only)](/windows/uwp/devices-sensors/host-card-emulation)
