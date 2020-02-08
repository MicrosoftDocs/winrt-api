---
-api-id: T:Windows.Devices.SmartCards.SmartCardCryptographicKeyAttestationStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Devices.SmartCards.SmartCardCryptographicKeyAttestationStatus : int
-->

# SmartCardCryptographicKeyAttestationStatus

## -description
Defines the attestation status of a key.

## -enum-fields
### -field NoAttestation:0
The key has no attestation.

### -field SoftwareKeyWithoutTpm:1
The key is a software key on a device without a TPM.

### -field SoftwareKeyWithTpm:2
The key is a software key on a device with a TPM.

### -field TpmKeyUnknownAttestationStatus:3
The TPM supporting the key has an unknown attestation status.

### -field TpmKeyWithoutAttestationCapability:4
The key is a TPM key on a device that does not have the ability to provide attestation.

### -field TpmKeyWithTemporaryAttestationFailure:5
The key is a TPM key with a temporary attestation failure.

### -field TpmKeyWithLongTermAttestationFailure:6
The key is a TPM key with a long term attestation failure.

### -field TpmKeyWithAttestation:7
The key is a TPM key with attestation.


## -remarks

## -examples

## -see-also
[Create an NFC Smart Card app (applies to Windows 10 Mobile only)](/windows/uwp/devices-sensors/host-card-emulation)
