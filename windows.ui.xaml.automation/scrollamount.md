---
-api-id: T:Windows.UI.Xaml.Automation.ScrollAmount
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.Automation.ScrollAmount : int
-->

# ScrollAmount

## -description
Contains values that are used by the [IScrollProvider](../windows.ui.xaml.automation.provider/iscrollprovider.md) pattern to indicate the direction and distance to scroll.



## -enum-fields
### -field LargeDecrement:0
Specifies that scrolling is performed in large decrements, which is equivalent to pressing the PAGE UP key or to clicking a blank part of a scrollbar. If the distance represented by the PAGE UP key is not a relevant amount for the control, or if no scrollbar exists, the value represents an amount equal to the size of the currently visible window.

### -field SmallDecrement:1
Specifies that scrolling is performed in small decrements, which is equivalent to pressing an arrow key or to clicking the arrow button on a scrollbar.

### -field NoAmount:2
Specifies that scrolling should not be performed.

### -field LargeIncrement:3
Specifies that scrolling is performed in large increments, which is equivalent to pressing the PAGE DOWN key or to clicking a blank part of a scrollbar. If the distance represented by the PAGE DOWN key is not a relevant amount for the control, or if no scrollbar exists, the value represents an amount equal to the size of the currently visible region.

### -field SmallIncrement:4
Specifies that scrolling is performed in small increments, which is equivalent to pressing an arrow key or to clicking the arrow button on a scrollbar.


## -remarks

## -examples

## -see-also
