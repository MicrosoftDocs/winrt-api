---
-api-id: T:Windows.UI.Composition.CompositionBatchTypes
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Composition.CompositionBatchTypes : uint
-->

# CompositionBatchTypes

## -description
Batch types for [CompositionCommitBatch](compositioncommitbatch.md) and [CompositionScopedBatch](compositionscopedbatch.md).



## -enum-fields
### -field None:0
None.

### -field Animation:1
The batch contains animations.

### -field Effect:2
The batch contains effects.

### -field AllAnimations:5

The batch contains all animations.

### -field InfiniteAnimation:4

The batch contains an infinite animation.


## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1809 | 17763 | AllAnimations |
| 1809 | 17763 | InfiniteAnimation |

## -examples

## -see-also
[Composition Animations Overview](/windows/uwp/composition/composition-animation)

