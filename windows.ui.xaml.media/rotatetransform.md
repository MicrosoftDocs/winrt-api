---
-api-id: T:Windows.UI.Xaml.Media.RotateTransform
-api-type: winrt class
---

<!-- Class syntax.
public class RotateTransform : Windows.UI.Xaml.Media.Transform, Windows.UI.Xaml.Media.IRotateTransform
-->

# Windows.UI.Xaml.Media.RotateTransform

## -description
Rotates an object around a specified point in a two-dimensional x-y coordinate system.



## -xaml-syntax
```xaml
<RotateTransform .../>
```


## -remarks
A RotateTransform is defined by an [Angle](rotatetransform_angle.md) that rotates an object through an arc around the point [CenterX](rotatetransform_centerx.md), [CenterY](rotatetransform_centery.md).

If the [Angle](rotatetransform_angle.md) value applied is positive, the rotation applied is in the clockwise direction. It's legal to use an [Angle](rotatetransform_angle.md) value that's negative, which causes the rotation to be counterclockwise. For values less than –360 or greater than 360, the values wrap around and are treated as if the mathematical operation `mod(360)` was applied.

To rotate in place, leave [CenterX](rotatetransform_centerx.md), [CenterY](rotatetransform_centery.md) as the default (0,0). You might use a nondefault [CenterX](rotatetransform_centerx.md), [CenterY](rotatetransform_centery.md) if you don't want to rotate in place and instead want to rotate around a point in the transform's frame of reference. For example, you can simulate an orbit.

A [Transform](transform.md) is typically used to fill the [UIElement.RenderTransform](../windows.ui.xaml/uielement_rendertransform.md) property, to change how an element renders. [UIElement](../windows.ui.xaml/uielement.md) also has the [UIElement.RenderTransformOrigin](../windows.ui.xaml/uielement_rendertransformorigin.md) property, which defaults to (0,0). [RenderTransformOrigin](../windows.ui.xaml/uielement_rendertransformorigin.md) establishes the coordinate frame of reference for how all transformations including the RotateTransform will apply. A common scenario for RotateTransform is to rotate an object in place around its center (either as an animation or as a one-time transformation). With the default [UIElement.RenderTransformOrigin](../windows.ui.xaml/uielement_rendertransformorigin.md) of (0,0) an object won't rotate around its center, it rotates around the top left corner of its bounding box. Therefore, the common way to cause an object to rotate around its center is to leave [CenterX](rotatetransform_centerx.md), [CenterY](rotatetransform_centery.md) as (0,0) but set [UIElement.RenderTransformOrigin](../windows.ui.xaml/uielement_rendertransformorigin.md) to be a logical [Point](../windows.foundation/point.md) where the values are (0.5,0.5). Using the logical point convention, that puts the [UIElement.RenderTransformOrigin](../windows.ui.xaml/uielement_rendertransformorigin.md) at the center point of the object, in other words at an origin where (*x*,*y*) are exactly half of the [ActualHeight](../windows.ui.xaml/frameworkelement_actualheight.md) and [ActualWidth](../windows.ui.xaml/frameworkelement_actualwidth.md) values.

[UIElement.RenderTransformOrigin](../windows.ui.xaml/uielement_rendertransformorigin.md) uses the logical point convention; [CenterX](rotatetransform_centerx.md) and [CenterY](rotatetransform_centery.md) don't use that convention, they use actual pixel values.

The rendering position for an object can be offset on a [Canvas](../windows.ui.xaml.controls/canvas.md) using [Canvas.Left](/uwp/api/windows.ui.xaml.controls.canvas.left) and [Canvas.Top](/uwp/api/windows.ui.xaml.controls.canvas.top), but this does not count as a transformation; the object retains its own local (0,0) origin when it's positioned in a [Canvas](../windows.ui.xaml.controls/canvas.md).

There are other properties and relationships that can affect how the rotation appears. If there are multiple transformations applied by using a [TransformGroup](transformgroup.md), the order matters. The transformations are applied in the order that they appear in the [TransformCollection](transformcollection.md). Especially if one of the transformations is a [TranslateTransform](translatetransform.md), you might have to alter the order to get the rotation effect you want.

There are three ways to apply multiple transformations to the same object: 
+ Using a [TransformGroup](transformgroup.md), where you can specify the order that each transformation applies.
+ Using a [CompositeTransform](compositetransform.md), where each of the transformations is enabled by properties of a shared [Transform](transform.md) object and the transformations are applied in a fixed, known order.
+ Using a [MatrixTransform](matrixtransform.md), where you set the various properties that control the 3×3 matrix in such a way that you're combining the typical classifications of transformations into one [Transform](transform.md). Unless you're using a design tool to help set the values, this is probably the most advanced technique.


### Animating a **RotateTransform**

You can apply an animation to a RotateTransform to cause an element to rotate over time. Typically you only apply the animation to the [Angle](rotatetransform_angle.md) property, and don't animate [CenterX](rotatetransform_centerx.md), [CenterY](rotatetransform_centery.md). For a continuously spinning animation, you'd typically use just the **To** value for a **From/To/By** style animation. [Angle](rotatetransform_angle.md) is a [Double](/dotnet/api/system.double?view=dotnet-uwp-10.0&preserve-view=true) so this involves a [DoubleAnimation](../windows.ui.xaml.media.animation/doubleanimation.md). For a continuous animation you'd set the [RepeatBehavior](../windows.ui.xaml.media.animation/timeline_repeatbehavior.md) of the [DoubleAnimation](../windows.ui.xaml.media.animation/doubleanimation.md) to **Forever**.
```xaml
<Page.Resources>
  <Storyboard x:Name="spinrect">
     <DoubleAnimation To="360" RepeatBehavior="Forever" 
         Storyboard.TargetName="spinme"
         Storyboard.TargetProperty="(UIElement.RenderTransform).(RotateTransform.Angle)" />
  </Storyboard>
</Page.Resources>
<StackPanel>
  <Rectangle Name="spinme" Width="50" Height="50" Fill="Red" RenderTransformOrigin=".5,.5"
      PointerPressed="spinme_PointerPressed">
    <Rectangle.RenderTransform>
      <RotateTransform/>
    </Rectangle.RenderTransform>
  </Rectangle>
</StackPanel>
```

```csharp
private void spinme_PointerPressed(object sender, PointerRoutedEventArgs e)
{
    spinrect.Begin();
}
```



## -examples
Transforms can alter the display of text in your application to create a decorative effect. This example shows text rotated 90 degrees using a RotateTransform.

This example uses a RotateTransform to rotate text. An [Angle](rotatetransform_angle.md) value of 90 rotates the element 90 degrees clockwise.



[!code-xaml[RotateTransform90DegreeText](../windows.ui.xaml/code/transforms/csharp/Rotate_90_Degrees_Text.xaml#SnippetRotateTransform90DegreeText)]

## -see-also
[XAML two-dimensional transforms sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/XAML%20two-dimensional%20transforms%20sample), [Transform](transform.md)
