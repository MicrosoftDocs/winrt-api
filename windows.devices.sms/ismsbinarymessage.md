---
-api-id: T:Windows.Devices.Sms.ISmsBinaryMessage
-api-type: winrt interface
---

<!-- Interface syntax.
public interface ISmsBinaryMessage : Windows.Devices.Sms.ISmsMessage
-->

# Windows.Devices.Sms.ISmsBinaryMessage

## -description
This interface provides access to the raw binary format of an SMS message. The message is stored in the industry standard protocol description unit (PDU) format (see the SMS specification GSM 03.40).

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators, mobile broadband adapter IHV, or OEM. For more information, see [Mobile Broadband](/windows-hardware/drivers/mobilebroadband/index).

## -remarks
### Interface inheritance

ISmsBinaryMessage inherits [ISmsMessage](ismsmessage.md). Types that implement ISmsBinaryMessage also implement the interface members of [ISmsMessage](ismsmessage.md).

## -examples

## -see-also
[ISmsMessage](ismsmessage.md)

## -capabilities
cellularMessaging, sms
