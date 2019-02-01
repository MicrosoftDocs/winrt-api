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
[Slider](../windows.ui.xaml.controls/slider.md) and [ProgressBar](../windows.ui.xaml.controls/progressbar.md) override the metadata of this property and set its default to 100. For more information, see [Dependency properties overview](https://msdn.microsoft.com/library/ad649e66-f71c-4daa-9994-617c886fda7e).

> [!NOTE]
> When binding [Minimum](rangebase_minimum.md) and [Maximum](rangebase_maximum.md) values in Extensible Application Markup Language (XAML), declare the [Binding](../windows.ui.xaml.data/binding.md) for [Maximum](rangebase_maximum.md) first. If the [Binding](../windows.ui.xaml.data/binding.md) for [Maximum](rangebase_maximum.md) is declared after [Minimum](rangebase_minimum.md), the bound value for [Maximum](rangebase_maximum.md) is ignored and the following situations can occur: + If the bound [Minimum](rangebase_minimum.md) value is negative, the [Maximum](rangebase_maximum.md) value is set to 0.
+ If the bound [Minimum](rangebase_minimum.md) value is greater than the default [Maximum](rangebase_maximum.md) (100 for [Slider](../windows.ui.xaml.controls/slider.md) and [ProgressBar](../windows.ui.xaml.controls/progressbar.md)), the [Maximum](rangebase_maximum.md) value is set equal to the [Minimum](rangebase_minimum.md) value.
To avoid this behavior, declare the [Binding](../windows.ui.xaml.data/binding.md) for [Maximum](rangebase_maximum.md) first in your Extensible Application Markup Language (XAML).

These behaviors can also occur if you set the [Minimum](rangebase_minimum.md) value without also explicitly setting the [Maximum](rangebase_maximum.md) value.

## -examples

## -see-also
