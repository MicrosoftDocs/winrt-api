---
-api-id: T:Windows.UI.Xaml.Controls.RelativePanel
-api-type: winrt class
---

<!-- Class syntax.
public class RelativePanel : Windows.UI.Xaml.Controls.Panel, Windows.UI.Xaml.Controls.IRelativePanel
-->

# Windows.UI.Xaml.Controls.RelativePanel

## -description
Defines an area within which you can position and align child objects in relation to each other or the parent panel.

 [RelativePanel](relativepanel.md) is a constraint based layout container that you can use to create UI by expressing spatial relationships between elements. Using [RelativePanel](relativepanel.md) ’s attached properties, you can position a UI element relative to another UI element (*A* is `RelativePanel.Below`  *B*) as well as relative to the panel (*A* is `RelativePanel.AlignTopWithPanel`).

## -xaml-syntax
```xaml
<RelativePanel ...>
  oneOrMoreUIElements
</RelativePanel>
-or-
<RelativePanel .../>
```


## -remarks
[RelativePanel](relativepanel.md) is a layout container that is useful for creating UI that do not have a clear linear pattern; that is, layouts that are not fundamentally stacked, wrapped, or tabular, where you might naturally use a [StackPanel](stackpanel.md) or [Grid](grid.md).

If your UI consists of multiple nested panels, [RelativePanel](relativepanel.md) is a good option to consider.


<!--{annotation author="jimwalk" time="6/18/2015 2:48:23 PM"}Add link to Layout overview.-->
Here's an example of a UI using a [RelativePanel](relativepanel.md) for its layout:

<img alt="Relative panel control" src="images/controls/RelativePanelBasic.png" />
```xaml
<RelativePanel BorderBrush="Gray" BorderThickness="10">
    <Rectangle x:Name="RedRect" Fill="Red" MinHeight="100" MinWidth="100"/>
    <Rectangle x:Name="BlueRect" Fill="Blue" MinHeight="100" MinWidth="100" 
               RelativePanel.RightOf="RedRect"/>
    <!-- Width is not set on the green and yellow rectangles.
         It's determined by the RelativePanel properties. -->
    <Rectangle x:Name="GreenRect" Fill="Green" MinHeight="100" Margin="0,5,0,0" 
               RelativePanel.Below="RedRect" 
               RelativePanel.AlignLeftWith="RedRect" 
               RelativePanel.AlignRightWith="BlueRect"/>
    <Rectangle Fill="Yellow" MinHeight="100" 
               RelativePanel.Below="GreenRect" 
               RelativePanel.AlignLeftWith="BlueRect" 
               RelativePanel.AlignRightWithPanel="True"/>
</RelativePanel>
```

[RelativePanel](relativepanel.md), used in conjunction with [AdaptiveTrigger](../windows.ui.xaml/adaptivetrigger.md) s, can be a powerful tool to create responsive UI that scales well across different screen sizes. For more examples, see the [XAML Responsive Techniques sample](http://go.microsoft.com/fwlink/p/?LinkId=620024&amp;amp;clcid=0x409).


<!--{annotation author="jimwalk" time="6/18/2015 2:47:39 PM"}Add link to Responsive UI doc when ready.-->

<!--{annotation author="jimwalk" time="5/21/2015 5:51:34 PM"}Should update link to FW link before release.-->

### Default position

By default, any unconstrained element declared as a child of the [RelativePanel](relativepanel.md) is given the entire available space and positioned at the (0, 0) coordinates (upper left corner) of the panel. So, if you are positioning a second element relative to an unconstrained element, keep in mind that the second element might get pushed out of the panel.

In this example, `RectA` doesn't have any constraints, so it's positioned at (0,0). `RectB` is not shown on the screen because it is declared to be [Above](relativepanel_above.md)  `RectA` and is therefore pushed out of the panel.

```xaml
<RelativePanel>
    <Rectangle Name="RectA" Fill="Red" Height="40" Width="40"/>
    <Rectangle Name="RectB" Fill="Blue" Height="40" Width="40"
               RelativePanel.Above="RectA"/>
</RelativePanel>
```



### Circular dependency

A circular dependency occurs when two elements inside a [RelativePanel](relativepanel.md) declare relationships with each other in any direction. For example, this XAML results in a design-time exception, "RelativePanel error: Circular dependency detected. Layout could not complete."

```xaml
<RelativePanel>
    <Rectangle Name="RectA" Fill="Red" Height="40" Width="40"
               RelativePanel.Above="RectB"/>
    <Rectangle Name="RectB" Fill="Blue" Height="40" Width="40"
               RelativePanel.Below="RectA"/>
</RelativePanel>
```



### Conflicting relationships

If you set multiple relationships that target the same edge of an element, you might have conflicting relationships in your layout as a result. When this happens, the relationships are applied in the following order of priority:
+ Panel alignment relationships ([AlignTopWithPanel](relativepanel_aligntopwithpanel.md), [AlignLeftWithPanel](relativepanel_alignleftwithpanel.md), …) are applied first.
+ Sibling alignment relationships ([AlignTopWith](relativepanel_aligntopwith.md), [AlignLeftWith](relativepanel_alignleftwith.md), …) are applied second.
+ Sibling positional relationships ([Above](relativepanel_above.md), [Below](relativepanel_below.md), [RightOf](relativepanel_rightof.md), [LeftOf](relativepanel_leftof.md)) are applied last.


The panel-center alignment properties ([AlignVerticalCenterWith](relativepanel_alignverticalcenterwith.md), [AlignHorizontalCenterWithPanel](relativepanel_alignhorizontalcenterwithpanel.md), ...) are typically used independently of other constraints and are applied if there is no conflict.

The [HorizontalAlignment](../windows.ui.xaml/frameworkelement_horizontalalignment.md) and [VerticalAlignment](../windows.ui.xaml/frameworkelement_verticalalignment.md) properties on UI elements are applied after relationship properties are evaluated and applied. These properties control the placement of the element within the available size for the element, if the desired size is smaller than the available size.

### Border properties

[RelativePanel](relativepanel.md) defines border properties that let you draw a border around the [RelativePanel](relativepanel.md) without using an additional [Border](border.md) element. The properties are [RelativePanel.BorderBrush](relativepanel_borderbrush.md), [RelativePanel.BorderThickness](relativepanel_borderthickness.md), [RelativePanel.CornerRadius](relativepanel_cornerradius.md), and [RelativePanel.Padding](relativepanel_padding.md).

```xaml
<RelativePanel BorderBrush="Red" BorderThickness="2" CornerRadius="10" Padding="12">
    <TextBox x:Name="textBox1" RelativePanel.AlignLeftWithPanel="True"/>
    <Button Content="Submit" RelativePanel.Below="textBox1"/>
</RelativePanel>
```



## -examples

## -see-also
[Panel](panel.md), [Define layouts with XAML](http://msdn.microsoft.com/library/8d4e4162-1c9c-48f4-8a94-34976fb17079), [Quickstart: Adding layout controls](http://msdn.microsoft.com/library/5ad6c2ac-7ad7-4f0e-9636-97a0b3fbc43f), [Alignment, margin, and padding](http://msdn.microsoft.com/library/9412abd4-3674-4865-b07d-64c7c26e4842), [Canvas](canvas.md), [Grid](grid.md), [StackPanel](stackpanel.md), [VariableSizedWrapGrid](variablesizedwrapgrid.md), [Controls list](http://msdn.microsoft.com/library/11172840-a63d-4f48-9db4-7baca06308ee), [Controls by function](http://msdn.microsoft.com/library/8db4347b-91d6-4659-91f2-80ecf7bbb596)
