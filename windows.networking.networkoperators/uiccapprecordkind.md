---
-api-id: T:Windows.Networking.NetworkOperators.UiccAppRecordKind
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Networking.NetworkOperators.UiccAppRecordKind : int
-->

# UiccAppRecordKind

## -description
Describes the kinds of UICC application record.

## -enum-fields
### -field Unknown:0
An unknown app record kind. For example, a UICC app that is enumerable by the modem, but is not an app used for cellular registration, would be reported as **Unknown**.

### -field Transparent:1
A transparent file - a sequence of bytes without further structure .

### -field RecordOriented:2
A file that consists of a sequence of records.


## -remarks

## -examples

## -see-also