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
The [SerialNumber](smbiosinformation_serialnumber.md) property securely retrieves the serial number from the SMBIOS for the system. This property is partial trust, so in a Windows Store app, you must specify the app in the system's metadata before retrieving any properties.

OEM use the [SerialNumber](smbiosinformation_serialnumber.md) property to aid in identification of devices for servicing and troubleshooting operations.

## -examples

## -see-also
