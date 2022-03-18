---
-api-id: P:Windows.System.Profile.SystemManufacturers.SmbiosInformation.SerialNumber
-api-type: winrt property
---

<!-- Property syntax
public string SerialNumber { get; }
-->

# Windows.System.Profile.SystemManufacturers.SmbiosInformation.SerialNumber

## -description
Gets the serial number from the SMBIOS for the system.

## -property-value
The serial number.

## -remarks
The SerialNumber property securely retrieves the serial number from the SMBIOS for the system.
For a UWP app to access the serial number,
the app must possess the `smbios` capability,
or the app must be designated as a
[Privileged App](/windows-hardware/drivers/devapps/step-2--create-device-metadata)
by the system manufacturer.

System manufacturers typically use the SerialNumber property to aid in identification of devices for servicing and troubleshooting operations.

## -examples

## -see-also

## -capabilities
smbios
