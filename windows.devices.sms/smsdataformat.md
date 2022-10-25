---
-api-id: T:Windows.Devices.Sms.SmsDataFormat
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Devices.Sms.SmsDataFormat : int
-->

# SmsDataFormat

## -description
This enumerated type identifies the format of a given protocol description unit (PDU) buffer.

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators, mobile broadband adapter IHV, or OEM. For more information, see [Mobile Broadband](/windows-hardware/drivers/mobilebroadband/index).

## -enum-fields
### -field Unknown:0
The data format is unknown.

### -field CdmaSubmit:1
The data format is CDMA WMT format of type submit.

### -field GsmSubmit:2
The data format is GSM of type submit.

### -field CdmaDeliver:3
The data format is CDMA WMT format of type deliver.

### -field GsmDeliver:4
The data format is GSM of type deliver.


## -remarks

## -examples

## -see-also


## -capabilities
cellularMessaging, sms
