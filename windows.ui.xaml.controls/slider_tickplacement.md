---
-api-id: P:Windows.UI.Xaml.Controls.Slider.TickPlacement
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Controls.Primitives.TickPlacement TickPlacement { get;  set; }
-->

# Windows.UI.Xaml.Controls.Slider.TickPlacement

## -description
Gets or sets a value that indicates where to draw tick marks in relation to the track.



## -xaml-syntax
```xaml
<Slider TickPlacement="tickPlacementMemberName" />
```


## -property-value
An enumeration value that specifies where to draw tick marks in relation to the track. The default is **Inline**.

## -remarks
The drawing of tick marks on a slider depends on both the [TickFrequency](slider_tickfrequency.md) and TickPlacement properties. In order for tick marks to be shown, you must set the [TickFrequency](slider_tickfrequency.md) property to a value greater than 0, and the TickPlacement property to a value other than **None**.

## -examples
Here's a slider with its [TickFrequency](slider_tickfrequency.md) set to 2 and its TickPlacement set to **BottomRight**.



[!code-xaml[3](../windows.ui.xaml.data/code/System.Windows.Controls.Extended.SliderSL/csharp/Page.xaml#Snippet3)]

## -see-also
[TickFrequency](slider_tickfrequency.md)
