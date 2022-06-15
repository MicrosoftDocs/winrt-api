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

Equivalent **WinUI 2 API for UWP**: [SliderSnapsTo](/windows/winui/api/microsoft.ui.xaml.controls.primitives.slidersnapsto) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

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
