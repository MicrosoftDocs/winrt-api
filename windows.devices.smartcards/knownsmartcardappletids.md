---
-api-id: T:Windows.Devices.SmartCards.KnownSmartCardAppletIds
-api-type: winrt class
ms.custom: RS5
---

<!-- Class syntax.
public class KnownSmartCardAppletIds 
-->

# Windows.Devices.SmartCards.KnownSmartCardAppletIds

## -description
A class that represents a selection of known smartcard applet IDs; exposing them via its properties.

## -remarks
An applet ID (also called an application ID, or AID) is an identifier (a sequence of 5 to 16 bytes) that represents an application on a smartcard. A SIM card (or UICC) is an example of a smartcard; as is an employee badge, or a credit card.

Several well-known AIDs exist. For payment scenarios, two important AIDs identify the payment system environment (PSE) and proximity payment system environment (PPSE) applications. When a payment terminal connects to a credit card, the first application that the terminal talks to is one of these. When inserting a credit card into a terminal, the PSE application is used. When tapping a card against a terminal with near-field communication (NFC), the PPSE application is used.

## -see-also

## -examples

