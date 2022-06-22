---
-api-id: P:Windows.UI.Text.ITextCharacterFormat.Weight
-api-type: winrt property
---

<!-- Property syntax
public int Weight { get;  set; }
-->

# Windows.UI.Text.ITextCharacterFormat.Weight

## -description
Gets or sets the font weight of the characters.



## -property-value
The font weight expressed as a numeric value. See Remarks.

## -remarks
In standard typography API, the weight of a font is typically expressed as a constant name, such as "Bold". Using constant names to set the Weight property is supported through type converter behaviors and by the [FontWeights](fontweights.md) support class.

The [FontWeights](fontweights.md) values correspond to the "usWeightClass" definition in the [OpenType specification](/typography/opentype/spec/). The "usWeightClass" represents an integer value between 1 and 999. Lower values indicate lighter weights; higher values indicate heavier weights.

## -examples

## -see-also
