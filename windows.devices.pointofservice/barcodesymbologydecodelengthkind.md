---
-api-id: T:Windows.Devices.PointOfService.BarcodeSymbologyDecodeLengthKind
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum BarcodeSymbologyDecodeLengthKind : int
-->

# Windows.Devices.PointOfService.BarcodeSymbologyDecodeLengthKind

## -description
The types of decode lengths that barcode symbologies can support.

## -enum-fields
### -field Range:2
Decode lengths between [DecodeLength1](barcodesymbologyattributes_decodelength1.md) and [DecodeLength2](barcodesymbologyattributes_decodelength2.md) single-byte characters. The order of [DecodeLength1](barcodesymbologyattributes_decodelength1.md) and [DecodeLength2](barcodesymbologyattributes_decodelength2.md) do not matter (either can be higher or lower than the other).

### -field Discrete:1
Decode lengths of either [DecodeLength1](barcodesymbologyattributes_decodelength1.md) or [DecodeLength2](barcodesymbologyattributes_decodelength2.md) single-byte characters.

### -field AnyLength:0
Decode lengths of any number. 

## -remarks

## -see-also

## -examples
