---
-api-id: P:Windows.UI.Xaml.Controls.Primitives.RangeBase.Maximum
-api-type: winrt property
---

<!-- Property syntax
public double Maximum { get;  set; }
-->

# Windows.UI.Xaml.Controls.Primitives.RangeBase.Maximum

## -description
Gets or sets the highest possible [Value](rangebase_value.md) of the range element.



## -xaml-syntax
```xaml
<rangeBase Maximum="double"/>
```


## -property-value
The highest possible [Value](rangebase_value.md) of the range element. The default is 1.

## -remarks
[Slider](../windows.ui.xaml.controls/slider.md) and [ProgressBar](../windows.ui.xaml.controls/progressbar.md) override the metadata of this property and set its default to 100. For more information, see [Dependency properties overview](/windows/uwp/xaml-platform/dependency-properties-overview).

> [!NOTE]
> When binding [Minimum](rangebase_minimum.md) and Maximum values in Extensible Application Markup Language (XAML), declare the [Binding](../windows.ui.xaml.data/binding.md) for Maximum first. If the [Binding](../windows.ui.xaml.data/binding.md) for Maximum is declared after [Minimum](rangebase_minimum.md), the bound value for Maximum is ignored and the following situations can occur: + If the bound [Minimum](rangebase_minimum.md) value is negative, the Maximum value is set to 0.
+ If the bound [Minimum](rangebase_minimum.md) value is greater than the default Maximum (100 for [Slider](../windows.ui.xaml.controls/slider.md) and [ProgressBar](../windows.ui.xaml.controls/progressbar.md)), the Maximum value is set equal to the [Minimum](rangebase_minimum.md) value.
To avoid this behavior, declare the [Binding](../windows.ui.xaml.data/binding.md) for Maximum first in your Extensible Application Markup Language (XAML).

These behaviors can also occur if you set the [Minimum](rangebase_minimum.md) value without also explicitly setting the Maximum value.

## -examples

## -see-also
