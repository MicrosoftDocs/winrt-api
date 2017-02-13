---
-api-id: P:Windows.Devices.Sms.ISmsTextMessage.PartReferenceId
-api-type: winrt property
---

<!-- Property syntax
public uint PartReferenceId { get; }
-->

# Windows.Devices.Sms.ISmsTextMessage.PartReferenceId

## -description
Indicates a reference value that can be used if the message is part of a multi-part message. If this message belongs to a multi-part message, the [PartNumber](smstextmessage_partnumber.md) value can be used to reconstruct the full original message, and each part of that message will have the same value for [PartReferenceId](smstextmessage_partreferenceid.md).

## -property-value
An unsigned integer determined by the sending network; it cannot be manipulated through this interface. If the network has its own policy on the lifetime of a multi-part message, this reference number might not be valid indefinitely.

## -remarks

## -examples

## -see-also


## -capabilities
sms, cellularMessaging