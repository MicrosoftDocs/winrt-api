---
-api-id: E:Windows.UI.Xaml.FrameworkElement.EffectiveViewportChanged
-api-type: winrt event
---

<!-- Event syntax.
public event TypedEventHandler EffectiveViewportChanged<FrameworkElement, EffectiveViewportChangedEventArgs>
-->

# Windows.UI.Xaml.FrameworkElement.EffectiveViewportChanged

## -description
Occurs when the [FrameworkElement](frameworkelement)'s *effective viewport* changes.

## -remarks
A scrolling control allows the user to pan/scroll through content that takes up more space than is available in the UI.  The portion of the content that the user sees is called the **viewport**.   

The [EffectiveViewportChanged](frameworkelement_effectiveviewportchanged) event provides multiple pieces of information:
1. The actual [EffectiveViewport](effectiveviewportchangedeventargs_effectiveviewport)
2. A calculation for the [MaxViewport](effectiveviewportchangedeventargs_maxviewport)
3. Scalar values for the [BringIntoViewDistanceX](effectiveviewportchangedeventargs_bringintoviewdistancex) and [BringIntoViewDistanceY](effectiveviewportchangedeventargs_bringintoviewdistancey)

##### EffectiveViewport
The **EffectiveViewport** is the intersection of all known viewports that contain the [FrameworkElement](frameworkelement) in their sub-tree.  If there are two or more viewports (e.g. a [ScrollViewer](../windows.ui.xaml.controls/scrollviewer) nested inside another [ScrollViewer](../windows.ui.xaml.controls/scrollviewer)) that do not overlap then the EffectiveViewport will be an empty [Rect](../windows.foundation/rect).

> [!NOTE]
> For a scrolling control's viewport to be *known* to the framework the control must have previously registered it using the [UIElement.RegisterAsScrollPort](uielement_registerasscrollport_591917999) method.  The framework will use the [Clip](uielement_clip) of the registered element when determining the effective viewport.
>
> When the scrolling control's viewport changes it must invoke its [InvalidateViewport](frameworkelement_invalidateviewport_528063221) to inform the framework that its viewport has changed and any of its sub-elements that listen to the effective viewport need to be notified of changes.

The [EffectiveViewport](effectiveviewportchangedeventargs_effectiveviewport) is given in the coordinate space of the [FrameworkElement](frameworkelement).  There's no need to perform a [TransformToVisual](uielement_transformtovisual_799251735) with the viewport [Rect](../windows.foundation/rect).
 
In a simple scenario where there is a [ScrollViewer](../windows.ui.xaml.controls/scrollviewer) that contains a single element, the [EffectiveViewportChanged](frameworkelement_effectiveviewportchanged) event provides viewport updates similar to the [ViewChanged](../windows.ui.xaml.controls/scrollviewer_viewchanged) event.  The main difference is that the EffectiveViewportChanged event is raised *after* the arrange pass of layout.

For example, this ...
```xml
<ScrollViewer>
    <Grid Height="4000" Width="4000"
          EffectiveViewportChanged="Grid_EffectiveViewportChanged"/>
</ScrollViewer>
```
... provides similar viewport information as this...

```xml
<ScrollViewer ViewChanged="ScrollViewer_ViewChanged">
    <Grid Height="4000" Width="4000"/>
</ScrollViewer>
```


##### MaxViewport

The **MaxViewport** is similar to the **EffectiveViewport**, but instead of representing a simple intersect of the known viewports, it represents the intersect of the viewports *as if each had been brought into view of any outer viewport*.  The resulting [Rect](../windows.foundation/rect) represents two things:
1. the largest size that the EffectiveViewport can be (given the current viewport sizes), and
2. the position of the maximum effective viewport relative to the [FrameworkElement](frameworkelement).

This information can be used to gauge where and how much content the [FrameworkElement](frameworkelement) should pre-generate to potentially fill the viewport *before* it is scrolled into view.
> [!NOTE]
> Scrolling via direct input such as touch or pen are handled by the system in a separate process.  By default, scrolling is handled asynchronously to the UI thread.  Controls that perform virtualization may need to pre-generate content well in advance of entering the viewport due to the inherent cost of element creation.  
>
> Delaying all content preparation until coming into view can lead to a poor scrolling experience for users.  Users may see blank space or stutters, both symptoms of the UI thread not being able to keep up with the speed of panning.

The [MaxViewport](effectiveviewportchangedeventargs_maxviewport)'s position is reported in the coordinate space of the [FrameworkElement](frameworkelement).  If the [MaxViewport](effectiveviewportchangedeventargs_maxviewport) were transformed to the coordinate space of the first viewport in the [FrameworkElement](frameworkelement)'s chain of ancestors, the [Rect](../windows.foundation/rect) would be within the bounds of that first viewport.

##### BringIntoViewDistanceX and Y
These values indicate how *close* the [FrameworkElement](frameworkelement) is to becoming maximally visible across all its viewports.  

If the value is greater than zero, but less than the [ActualWidth](frameworkelement_actualwidth) / [ActualHeight](frameworkelement_actualheight) then the element is partially within the user-visible viewport.  When the values are zero then the [FrameworkElement](frameworkelement) is fully within the user-visible viewport.  **Note:** This does not guarantee that the element is visible to the user since other elements with a higher Z-order may still be occluding the [FrameworkElement](frameworkelement).

Stated more formally, these values are the sum of the absoluate distance that the [FrameworkElement](frameworkelement) would be translated when satisfying a call to [StartBringIntoView](uielement_startbringintoview_1818344798).  The values do not account for the possibility that a scroll control has disabled scrolling.

```xml
<ListView x:Name="lv">
    <ListView.ItemTemplate>
        <DataTemplate x:DataType="x:String">
            <UserControl Tag="{x:Bind}" EffectiveViewportChanged="Item_EffectiveViewportChanged"/>
        </DataTemplate>
    </ListView.ItemTemplate>
</ListView>
```


```csharp
private void Item_EffectiveViewportChanged(FrameworkElement sender, EffectiveViewportChangedEventArgs args)
{
    // If we wanted to know if a list item (w/ vertical scrolling only) is partially within the viewport
    // then we can just check the BringIntoViewDistanceY of the event args.  If the distance is 0 then the item is fully within 
    // the effective viewport.  If the BringIntoViewDistanceY is less than the sender’s ActualHeight, then its 
    // partially within the effective viewport.
    // The EffectiveViewport rect is relative to the ‘sender’ so we can use it to know where the element is within the viewport.  
    // NOTE: "Within the viewport" != visible to the user's eye since another element may overlap obscuring it.
    if (args.BringIntoViewDistanceY < sender.ActualHeight)
    {
        Debug.WriteLine($"Item: {sender.Tag} has {sender.ActualHeight - args.BringIntoViewDistanceY} pixels within the viewport");
    }
    else
    {
        Debug.WriteLine($"Item: {sender.Tag} has {args.BringIntoViewDistanceY - sender.ActualHeight} pixels to go before it is even partially visible");
    }

    // Consider disconnecting from the effective viewport when not needed.  Otherwise, it is called on every 
    // viewport change.
    //lv.EffectiveViewportChanged -= Item_EffectiveViewportChanged;
}

```

#### Behavior
* If the effective viewport of a parent and child both change, the parent will receive the notification before the child.
* The event is only raised for elements in the UI tree that participate in layout.  For example, if the element isn’t in the live tree, or if the Visibility property of the element or any of its ancestors is set to Collapsed, this event won’t be raised.
* Although the effective viewport does account for render transforms for all the elements ancestors, it does not consider the effects of clipping (other than the clip of the element registered by a scrolling control as its viewport).
* The effective viewport does not account for occlusion due to other elements having a higher Z-order.



## -see-also
* [UIElement.RegisterAsScrollPort](uielement_registerasscrollport_591917999)
* [FrameworkElement.EffectiveViewportChanged](frameworkelement_effectiveviewportchanged)
* [FrameworkElement.InvalidateViewport](frameworkelement_invalidateviewport_528063221)

## -examples

