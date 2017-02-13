---
-api-id: P:Windows.Devices.Sms.ISmsTextMessage.PartNumber
-api-type: winrt property
---

<!-- Property syntax
public uint PartNumber { get; }
-->

# Windows.Devices.Sms.ISmsTextMessage.PartNumber

## -description
Retrieves the part number of a multi-part message if this message is part of a multi-part message. It can be used to reconstruct the original message by joining the parts together, in conjunction with the PartReferenceId and PartCount properties.

## -property-value
An unsigned integer. It is one-based. It will not exceed PartCount + 1.

## -remarks

## -examples

## -see-also


## -capabilities
sms, cellularMessaging