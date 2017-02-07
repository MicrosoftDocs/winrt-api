---
-api-id: T:Windows.UI.Text.Core.CoreTextFormatUpdatingReason
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Text.Core.CoreTextFormatUpdatingReason : int
-->

# CoreTextFormatUpdatingReason

## -description
Defines constants that specify the set of state applied during text composition.

## -enum-fields
### -field None:0
The reason for the format updating is unknown.

### -field CompositionUnconverted:1
The text is an unconverted composition string.

### -field CompositionConverted:2
The text is a converted composition string.

### -field CompositionTargetUnconverted:3
The user has made a selection in the composition string and the text has been converted.

### -field CompositionTargetConverted:4
The user made a selection in the composition string, but the text has not yet been converted.


## -remarks

## -examples

## -see-also