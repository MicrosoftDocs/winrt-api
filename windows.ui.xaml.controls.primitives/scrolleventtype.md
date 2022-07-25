---
-api-id: T:Windows.UI.Xaml.Controls.Primitives.ScrollEventType
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.Controls.Primitives.ScrollEventType : int
-->

# ScrollEventType

## -description
Defines constants that specify the type of [Scroll](scrollbar_scroll.md) event that occurred.



## -enum-fields
### -field SmallDecrement:0
The [Thumb](thumb.md) moved a distance specified by the value of [SmallChange](rangebase_smallchange.md). The [Thumb](thumb.md) moved to the left for a horizontal [ScrollBar](scrollbar.md) or upward for a vertical [ScrollBar](scrollbar.md).

### -field SmallIncrement:1
The [Thumb](thumb.md) moved a distance specified by the value of [SmallChange](rangebase_smallchange.md). The [Thumb](thumb.md) moved to the right for a horizontal [ScrollBar](scrollbar.md) or downward for a vertical [ScrollBar](scrollbar.md).

### -field LargeDecrement:2
The [Thumb](thumb.md) moved a distance specified by the value of [LargeChange](rangebase_largechange.md). The [Thumb](thumb.md) moved to the left for a horizontal [ScrollBar](scrollbar.md) or upward for a vertical [ScrollBar](scrollbar.md).

### -field LargeIncrement:3
The [Thumb](thumb.md) moved a distance specified by the value of [LargeChange](rangebase_largechange.md). The [Thumb](thumb.md) moved to the right for a horizontal [ScrollBar](scrollbar.md) or downward for a vertical [ScrollBar](scrollbar.md).

### -field ThumbPosition:4
The [Thumb](thumb.md) moved to a new position because the user selected **Scroll Here** in the shortcut menu of the [ScrollBar](scrollbar.md).

### -field ThumbTrack:5
The [Thumb](thumb.md) was dragged and caused a [PointerMoved](../windows.ui.xaml/uielement_pointermoved.md) event. A [Scroll](scrollbar_scroll.md) event of this ScrollEventType may occur more than one time when the [Thumb](thumb.md) is dragged in the [ScrollBar](scrollbar.md).

### -field First:6
The [Thumb](thumb.md) moved to the [Minimum](rangebase_minimum.md) position of the [ScrollBar](scrollbar.md).

### -field Last:7
The [Thumb](thumb.md) moved to the [Maximum](rangebase_maximum.md) position of the [ScrollBar](scrollbar.md).

### -field EndScroll:8
The [Thumb](thumb.md) was dragged to a new position and is now no longer being dragged by the user.


## -remarks

## -examples

## -see-also
