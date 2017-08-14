---
-api-id: M:Windows.Devices.Sms.ISmsDevice.CalculateLength(Windows.Devices.Sms.SmsTextMessage)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Devices.Sms.SmsEncodedLength CalculateLength(Windows.Devices.Sms.SmsTextMessage message)
-->

# Windows.Devices.Sms.ISmsDevice.CalculateLength

## -description
Estimates the transmitted message length of the specified text message. The estimate can be useful to clients who want to give an indication of how many messages will be sent on the network to carry the text of the full message.

## -parameters
### -param message
A reference to the SMS text message to measure.

## -returns
A reference to an SmsEncodedLength structure that is populated with the length information.

## -remarks

## -examples

## -see-also


## -capabilities
cellularMessaging, sms
