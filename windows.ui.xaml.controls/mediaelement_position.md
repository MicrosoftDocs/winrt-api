---
-api-id: P:Windows.UI.Xaml.Controls.MediaElement.Position
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.TimeSpan Position { get;  set; }
-->

# Windows.UI.Xaml.Controls.MediaElement.Position

## -description
Gets or sets the current position of progress through the media's playback time.


## -property-value
The amount of time since the beginning of the media. The default is a **TimeSpan** with value "0:0:0".
<!--Do not link TimeSpan in authoring above, it is a projected type and if you link only one of them you produce a language bias.-->

## -remarks
Set this property to set a specific start-play position within the media.

A **TimeSpan** is represented as different types depending on the programming language you are using. 

> **C# or Microsoft Visual Basic**
> Use a [System.TimeSpan](/dotnet/api/system.timespan?view=dotnet-uwp-10.0&preserve-view=true) structure. [System.TimeSpan](/dotnet/api/system.timespan?view=dotnet-uwp-10.0&preserve-view=true) has utility members such as [Parse(String)](/dotnet/api/system.timespan.parse?view=dotnet-uwp-10.0&preserve-view=true) that make it easy to create, change or compare time values.



> **Visual C++ component extensions (C++/CX)**
> Use a [Windows::Foundation::TimeSpan](../windows.foundation/timespan.md) structure. This structure has only one field member (**Duration**), which measures by 100-nanosecond units. If you intend to display a Position value in an hours:minutes:seconds format, you'll have to write your own logic for converting to that format from the **Duration** units.

If you are not sure of the current media source loaded as [MediaElement.Source](mediaelement_source.md), always check [CanSeek](mediaelement_canseek.md) first. A streaming media source results in the [MediaElement](mediaelement.md) reporting [CanSeek](mediaelement_canseek.md) as **false**, and in this case you cannot use Position to set the playback point.
<!--Silverlight did not report this as an exception AFAIK, it was a no op, test-->

If Position is settable, then these value constraints apply:
+ If Position is set to a negative value, the value will revert to a **TimeSpan** with value "0:0:0".
+ If Position is set to a value larger than the media's [NaturalDuration](mediaelement_naturalduration.md), then Position becomes the value of [NaturalDuration](mediaelement_naturalduration.md).





<!--<rem>The <xref targtype="property_winrt" rid="w_ui_xaml_ctrl.mediaelement_position">Position</xref> value when media is being played is often presented to the user as a <xref targtype="class_winrt" rid="w_ui_xaml_ctrl.slider">Slider</xref> control. This is shown briefly in the example in this topic, and you can see more code for associating the  <xref targtype="property_winrt" rid="w_ui_xaml_ctrl.mediaelement_position">Position</xref> value with a <xref targtype="class_winrt" rid="w_ui_xaml_ctrl.slider">Slider</xref> in <xref rid="m_media_mca.create_media_player" targtype="ovw" local="slider_progress_bar">Quickstart: Creating a media player app</xref>.</rem>-->
### Notes on XAML syntax

Setting a Position value in XAML is technically possible but not common. If you do set a Position in XAML, simulate the "FromString" type conversion behavior for a **TimeSpan**, in other words specify the value in the form "HH:MM:SS".

## -examples

## -see-also
[NaturalDuration](mediaelement_naturalduration.md)
