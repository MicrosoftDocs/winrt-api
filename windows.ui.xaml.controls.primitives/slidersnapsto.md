---
-api-id: T:Windows.UI.Xaml.Controls.Primitives.SliderSnapsTo
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.Controls.Primitives.SliderSnapsTo : int
-->

# SliderSnapsTo

## -description
Defines constants that specify how a [Slider](../windows.ui.xaml.controls/slider.md) or related range control class conforms the indicator position to its steps or tick marks.


## -xaml-syntax
```xaml
<objectproperty="enumMemberName" />
```


## -enum-fields
### -field StepValues:0
Conform the indicator to the step values.

### -field Ticks:1
Conform the indicator to the tick marks.


## -remarks

## -examples
```xaml
<Slider TickPlacement="Inline"
        TickFrequency="20"
        SnapsTo="Ticks"/>
```



## -see-also
[Slider.SnapsTo](../windows.ui.xaml.controls/slider_snapsto.md)
