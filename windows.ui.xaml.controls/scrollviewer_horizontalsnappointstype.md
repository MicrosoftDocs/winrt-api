---
-api-id: P:Windows.UI.Xaml.Controls.ScrollViewer.HorizontalSnapPointsType
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Controls.SnapPointsType HorizontalSnapPointsType { get;  set; }
-->

# Windows.UI.Xaml.Controls.ScrollViewer.HorizontalSnapPointsType

## -description
Gets or sets a value that declares how manipulation behavior reacts to the snap points along the horizontal axis.



## -xaml-syntax
```xaml
<ScrollViewer HorizontalSnapPointsType="snapPointsTypeMemberName" />
```


## -property-value
A value of the enumeration. The default is **None** but might be set through a control template.

## -remarks
For panning actions, there are often natural stopping places. Snap points provide a way to indicate where these places are. Then, when a user swipes, the manipulation result favors that natural point using behavior as expressed by a [SnapPointsType](snappointstype.md) value.

**Proximity points (****Optional**** and ****OptionalSingle****):
** When a user is going to naturally stop the manipulation in the proximity of a snap point, proximity points help the user land at the natural stopping place. Because the user has to land in proximity to the snap point to cause it to stop there, the user will sometimes have to perform another swipe to reach a snap point.

**Mandatory snap points (****Mandatory**** and ****MandatorySingle**)**:
** In contrast to proximity, mandatory snap points ensure that the content is adjusted to always land on a snap point. Even if the user releases the manipulation halfway between two snap-points, it will always move to one of the snap points.

To see the effects of snap points on [ScrollViewer](scrollviewer.md) behavior yourself, get the [XAML scrolling, panning and zooming sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/XAML%20scrolling%2C%20panning%2C%20and%20zooming%20sample). Run the sample on a touch device (not the simulator). Try out the [SnapPointsType](snappointstype.md) values when you view the "Panning with snap-points" example page of the sample.

To learn more about the swipe gesture and panning, see the "Panning behaviors" section of [Guidelines for panning](/windows/uwp/input-and-devices/guidelines-for-panning).

The default value of **None** is the default of the enumeration. If it's set, this property is often set as an attribute in a XAML template part, or as a style [Setter](../windows.ui.xaml/setter.md). Each control potentially sets this differently. Getting the value at run time will provide the value that came from applied styles and templates.

## -examples
This XAML is from the default template for a [Hub](hub.md) control. A [Hub](hub.md) has a [ScrollViewer](scrollviewer.md) part that surrounds an [ItemsStackPanel](itemsstackpanel.md) for its content. [Hub](hub.md) uses the **Optional** value for its snapping behavior in both dimensions (although [VerticalScrollMode](scrollviewer_verticalscrollmode.md) is disabled in starting visual states) and disables [ZoomMode](scrollviewer_zoommode.md). Note how the **SnapPointsAlignment** properties are also set as attributes here.

```xaml

<ControlTemplate TargetType="Hub">
...
<ScrollViewer x:Name="ScrollViewer"
    Grid.RowSpan="2"
    HorizontalScrollMode="Auto"
    HorizontalScrollBarVisibility="Auto"
    VerticalScrollMode="Disabled"
    VerticalScrollBarVisibility="Disabled"
    HorizontalSnapPointsAlignment="Near"
    HorizontalSnapPointsType="Optional"
    VerticalSnapPointsAlignment="Near"
    VerticalSnapPointsType="Optional"
    ZoomMode="Disabled">
  <ItemsStackPanel x:Name="Panel" 
       Orientation="{TemplateBinding Orientation}"
       CacheLength="20" />
</ScrollViewer>
...
</ControlTemplate>
```



## -see-also
[SnapPointsType](snappointstype.md), [XAML scrolling, panning and zooming sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/XAML%20scrolling%2C%20panning%2C%20and%20zooming%20sample), [Scroll viewer controls](/windows/uwp/design/controls-and-patterns/scroll-controls), [Guidelines for panning](/windows/uwp/design/input/guidelines-for-panning)
