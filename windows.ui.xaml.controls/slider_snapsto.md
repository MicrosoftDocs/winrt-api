---
-api-id: P:Windows.UI.Xaml.Controls.Slider.SnapsTo
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Controls.Primitives.SliderSnapsTo SnapsTo { get;  set; }
-->

# Windows.UI.Xaml.Controls.Slider.SnapsTo

## -description
Gets or sets a value that indicates how the [Slider](slider.md) conforms the thumb position to its steps or tick marks.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Controls.Slider.SnapsTo](/windows/winui/api/microsoft.ui.xaml.controls.slider.snapsto) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<Slider SnapsTo="sliderSnapsToMemberName" />
```


## -property-value
An enumeration value that specifies whether the [Slider](slider.md) snaps to steps or tick marks. The default is **StepValues**.

## -remarks
Set the SnapsTo property to specify whether the [Slider](slider.md) snaps to tick marks or step values. Set the [TickFrequency](slider_tickfrequency.md) or [StepFrequency](slider_stepfrequency.md) property to specify the interval between snap points.

## -examples

## -see-also
[StepFrequency](slider_stepfrequency.md), [TickFrequency](slider_tickfrequency.md)
