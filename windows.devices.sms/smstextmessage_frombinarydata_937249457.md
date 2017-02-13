---
-api-id: M:Windows.Devices.Sms.SmsTextMessage.FromBinaryData(Windows.Devices.Sms.SmsDataFormat,System.Byte[])
-api-type: winrt method
---

<!-- Method syntax
public Windows.Devices.Sms.SmsTextMessage FromBinaryData(Windows.Devices.Sms.SmsDataFormat format, System.Byte[] value)
-->

# Windows.Devices.Sms.SmsTextMessage.FromBinaryData

## -description
Decodes a binary message and places the results in a new instance of a text message. This method represents the binary message as a reference to a buffer of bytes and a selection of how the buffer is encoded. Therefore, it can be used when the message did not originate directly from the device or as an instance of an [SmsBinaryMessage](smsbinarymessage.md) class.

## -parameters
### -param format
An [SmsDataFormat](smsdataformat.md) enumerated value that identifies the format of a particular protocol description unit (PDU) buffer.

### -param value
An array of bytes containing the binary data to decode.

## -returns
A new [SmsTextMessage](smstextmessage.md) object if the decoding was successful.

## -remarks

## -examples

## -see-also


## -capabilities
sms, cellularMessaging