---
-api-id: T:Windows.Devices.Sms.SmsEncoding
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Devices.Sms.SmsEncoding : int
-->

# SmsEncoding

## -description
This enumerated type is used to determine the encoding algorithm to send or calculate the length of an [SmsTextMessage](smstextmessage.md) object.

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators, mobile broadband adapter IHV, or OEM. For more information, see [Mobile Broadband](/windows-hardware/drivers/mobilebroadband/index).

## -enum-fields
### -field Unknown:0
The data encoding is unknown.

### -field Optimal:1
7-bit encoding if all characters can be represented, otherwise 2-byte Universal Character Set (UCS-2) encoding.

### -field SevenBitAscii:2
Seven-bit ASCII encoding.

### -field Unicode:3
Unicode encoding.

### -field GsmSevenBit:4
Standard 7-bit GSM encoding.

### -field EightBit:5
Standard eight bit encoding.

### -field Latin:6
Latin encoding.

### -field Korean:7
Korean encoding.

### -field IA5:8
IA5 encoding.

### -field ShiftJis:9
Shift-JIS encoding for the Japanese language.

### -field LatinHebrew:10
Latin Hebrew encoding.


## -remarks
The encodings are defined in sections 4.5.2 and 23.038 of the 3GPP2 specification C.S0015-B "Short Message Service (SM) for Wideband Spread Spectrum Systems".

## -examples

## -see-also


## -capabilities
cellularMessaging, sms
