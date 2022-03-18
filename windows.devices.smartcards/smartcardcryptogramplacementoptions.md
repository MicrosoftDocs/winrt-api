---
-api-id: T:Windows.Devices.SmartCards.SmartCardCryptogramPlacementOptions
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Devices.SmartCards.SmartCardCryptogramPlacementOptions : uint
-->

# SmartCardCryptogramPlacementOptions

## -description
Defines cryptogram placement options.

## -enum-fields
### -field None:0
The placement option does not have a defined format.

### -field UnitsAreInNibbles:1
The [CryptogramOffset](smartcardcryptogramplacementstep_cryptogramoffset.md), [TemplateOffset](smartcardcryptogramplacementstep_templateoffset.md), and [CryptogramLength](smartcardcryptogramplacementstep_cryptogramlength.md) values are in nibbles and not bytes.

### -field ChainOutput:2
The placement step's output should be chained into the specified step.


## -remarks

## -examples

## -see-also
[Create an NFC Smart Card app (applies to Windows 10 Mobile only)](/windows/uwp/devices-sensors/host-card-emulation)
