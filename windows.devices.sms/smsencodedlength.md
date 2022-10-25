---
-api-id: T:Windows.Devices.Sms.SmsEncodedLength
-api-type: winrt struct
-api-device-family-note: xbox
---

<!-- Structure syntax.
public struct SmsEncodedLength 
-->

# SmsEncodedLength

## -description
This structure represents information about the length of an [SmsTextMessage](ismstextmessage.md) object when it is encoded as a PDU.

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators, mobile broadband adapter IHV, or OEM. For more information, see [Mobile Broadband](/windows-hardware/drivers/mobilebroadband/index).

## -struct-fields

### -field SegmentCount
The number of segments needed to encode the message.
    

### -field CharacterCountLastSegment
The number of characters in the last segment of the encoded message.
    

### -field CharactersPerSegment
The estimated number of characters that can fit in one segment of the message.
    

### -field ByteCountLastSegment
The number of bytes in the last segment of the encoded message.
    

### -field BytesPerSegment
The number of bytes in each segment of the message.
    

## -remarks

## -examples

## -see-also


## -capabilities
cellularMessaging, sms
