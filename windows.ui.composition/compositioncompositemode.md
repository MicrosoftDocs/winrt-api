---
-api-id: T:Windows.UI.Composition.CompositionCompositeMode
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Composition.CompositionCompositeMode : int
-->

# CompositionCompositeMode

## -description
Determines how a non-opaque visual's content is blended with the background content behind the visual.



## -enum-fields
### -field Inherit:0
Inherits mode from parent visual.

### -field SourceOver:1
The standard Composite Mode. Colors are blended with per-pixel transparency.

### -field DestinationInvert:2
The visual content's colors are inverted.

### -field MinBlend:3
Visual content's colors subtract for color channels in the background.


## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | MinBlend |

## -examples

## -see-also
