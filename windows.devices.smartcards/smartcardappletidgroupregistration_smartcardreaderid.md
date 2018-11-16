---
-api-id: P:Windows.Devices.SmartCards.SmartCardAppletIdGroupRegistration.SmartCardReaderId
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public string SmartCardReaderId { get; }
-->

# Windows.Devices.SmartCards.SmartCardAppletIdGroupRegistration.SmartCardReaderId

## -description
Gets the ID of any [SmartCardReader](smartcardreader.md) associated with a secure element. You can pass this ID to [SmartCardReader.FromIdAsync](smartcardreader_fromidasync_1322863552.md).

## -property-value
A string containing the ID of any [SmartCardReader](smartcardreader.md) associated with a secure element.

## -remarks
Some secure element types&mdash;for example, an embedded secure element (eSE), or a SIM card (UICC)&mdash;have a smartcard reader associated with them. If a registration's secure element is associated with a smartcard reader, then **SmartCardReaderId** provides the ID of that reader.

## -see-also

## -examples

