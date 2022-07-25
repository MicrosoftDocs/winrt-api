---
-api-id: P:Windows.UI.Xaml.UIElement.Transform3D
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.Media3D.Transform3D Transform3D { get;  set; }
-->

# Windows.UI.Xaml.UIElement.Transform3D

## -description

Gets or sets the 3-D transform effect to apply when rendering this element.



## -property-value

The 3-D transform effect to apply when rendering this element. The default is **null**.

## -remarks

Use the Transform3D property to apply a 3-D transform matrix to a XAML element. This lets you create effects where two-dimensional UI appears to exist in 3-D space relative to the user. Transform3D behaves much like [RenderTransform](uielement_rendertransform.md), but allows transforms in three-dimensional space and not just two dimensions.

### PerspectiveTransform3D and CompositeTransform3D

There are two subclasses of [Transform3D](../windows.ui.xaml.media.media3d/transform3d.md) that you can use to populate the Transform3D property. You should always use these subclasses together to create a 3-D scene. In very simple terms, you apply a [PerspectiveTransform3D](../windows.ui.xaml.media.media3d/perspectivetransform3d.md) to the root element of your scene to provide a common viewport for all the elements in it. Then you apply a [CompositeTransform3D](../windows.ui.xaml.media.media3d/compositetransform3d.md) to individual elements in the scene to rotate, scale, and move them in relation to the common viewport.

[PerspectiveTransform3D](../windows.ui.xaml.media.media3d/perspectivetransform3d.md) represents a 3-D perspective transform matrix, and creates a frame of reference and viewport for a 3-D scene. Under a perspective effect, elements further away from the user appear to shrink towards a common vanishing point, as if they were actually viewed in three-dimensional space. Because the perspective effect should apply to all elements in a shared 3-D scene, it is usually applied at the root of 3-D content such as the [Page](../windows.ui.xaml.controls/page.md) element. The effect is inherited by children of this element. [PerspectiveTransform3D](../windows.ui.xaml.media.media3d/perspectivetransform3d.md) preserves coordinates in the Z=0 plane, where UI elements reside by default. Therefore, [PerspectiveTransform3D](../windows.ui.xaml.media.media3d/perspectivetransform3d.md) (inherited from the root element) affects the appearance of an element only if the element is also transformed by a [CompositeTransform3D](../windows.ui.xaml.media.media3d/compositetransform3d.md), which moves it out of the Z=0 plane.

[CompositeTransform3D](../windows.ui.xaml.media.media3d/compositetransform3d.md) represents a group of affine 3-D transforms on an element, including rotation, scale and translation. This class is used to position elements in 3-D space.

Here's an example of using the [Transform3D](../windows.ui.xaml.media.media3d/transform3d.md) subclasses to achieve a 3-D effect for your UI:

```xaml
<StackPanel Orientation="Horizontal">
    <StackPanel.Transform3D>
        <PerspectiveTransform3D />
    </StackPanel.Transform3D>

    <Rectangle Width="300" Height="200" Fill="CornflowerBlue" />

    <Rectangle Width="300" Height="200" Fill="CadetBlue" Margin="10">
        <Rectangle.Transform3D>
            <CompositeTransform3D RotationY="-30" TranslateZ="-75" CenterX="150" />
        </Rectangle.Transform3D>
    </Rectangle>

    <Rectangle Width="300" Height="200" Fill="OrangeRed">
        <Rectangle.Transform3D>
            <CompositeTransform3D TranslateZ="-150" />
        </Rectangle.Transform3D>
    </Rectangle>
</StackPanel>
```

<img src="images/Transform3D.png" alt="Rectangles with 3-D transforms" />

In this example, a [PerspectiveTransform3D](../windows.ui.xaml.media.media3d/perspectivetransform3d.md) is attached to the root [StackPanel](../windows.ui.xaml.controls/stackpanel.md) and provides a shared perspective viewport for the panel's children.

+ The [Rectangle](../windows.ui.xaml.shapes/rectangle.md) on the left has no transform, so it appears as normal.
+ The [Rectangle](../windows.ui.xaml.shapes/rectangle.md) in the center is rotated -30 degrees about its central axis and translated back 75 pixels, causing its right edge to have a Z-coordinate of -150 pixels.
+ The [Rectangle](../windows.ui.xaml.shapes/rectangle.md) on the right is translated back 150 pixels.

The edges of the three rectangles appear to be contiguous because they share a common perspective.

### Animating CompositeTransform3D

You can animate each property of a [CompositeTransform3D](../windows.ui.xaml.media.media3d/compositetransform3d.md) independently. For more info about animations, see [Storyboarded animations](/windows/uwp/graphics/storyboarded-animations) and [Key-frame and easing function animations](/windows/uwp/graphics/key-frame-and-easing-function-animations).

In this example, animations are applied the [RotationY](../windows.ui.xaml.media.media3d/compositetransform3d_rotationy.md) and [TranslateZ](../windows.ui.xaml.media.media3d/compositetransform3d_translatez.md) properties to make the middle rectangle appear to drop into place. The end result when the animations have stopped is the same as the previous example.

```xaml
<StackPanel Orientation="Horizontal" Loaded="StackPanel_Loaded">
    <StackPanel.Resources>
        <Storyboard x:Name="rect2Storyboard">
            <DoubleAnimation 
                Storyboard.TargetName="rectangle2"
                Storyboard.TargetProperty="(UIElement.Transform3D).(CompositeTransform3D.RotationY)"
                From="0" To="-30" Duration="0:0:5"/>
            <DoubleAnimation
                Storyboard.TargetName="rectangle2"
                Storyboard.TargetProperty="(UIElement.Transform3D).(CompositeTransform3D.TranslateZ)"
                From="175" To="-75" Duration="0:0:10"/>
        </Storyboard>
    </StackPanel.Resources>
    <StackPanel.Transform3D>
        <PerspectiveTransform3D />
    </StackPanel.Transform3D>

    <Rectangle Width="300" Height="200" Fill="CornflowerBlue" />

    <Rectangle x:Name="rectangle2" Width="300" Height="200" Fill="CadetBlue" Margin="10">
        <Rectangle.Transform3D>
            <CompositeTransform3D CenterX="150" />
        </Rectangle.Transform3D>
    </Rectangle>

    <Rectangle Width="300" Height="200" Fill="OrangeRed">
        <Rectangle.Transform3D>
            <CompositeTransform3D TranslateZ="-150" />
        </Rectangle.Transform3D>
    </Rectangle>
</StackPanel>
```

```csharp
private void StackPanel_Loaded(object sender, RoutedEventArgs e)
{
    rect2Storyboard.Begin();
}
```



### Transform3D and PlaneProjection

Prior to Windows 10, the only way to create 3-D effects was to set the [Projection](uielement_projection.md) property. When using [Projection](uielement_projection.md), 3-D transforms are not inherited down the XAML tree. Therefore, [Projection](uielement_projection.md) is suitable only for applying effects where elements are transformed in local coordinates, not relative to a shared perspective viewport. This same effect can be achieved by setting [PerspectiveTransform3D](../windows.ui.xaml.media.media3d/perspectivetransform3d.md) on a local element. For this reason, we recommend that you use Transform3D for all but the most simple 3-D effects, and whenever you need a shared perspective.

> [!NOTE]
> Transform3D does not affect the order in which elements are drawn. Elements further away from the viewer along the Z-axis might still be rendered above elements that are closer. You can use the [Canvas.ZIndex](/uwp/api/windows.ui.xaml.controls.canvas.zindex) attached property and the position of elements in the XAML visual tree to manage the drawing order of elements in your UI.

## -examples

## -see-also

[PerspectiveTransform3D](../windows.ui.xaml.media.media3d/perspectivetransform3d.md), [CompositeTransform3D](../windows.ui.xaml.media.media3d/compositetransform3d.md), [PlaneProjection](../windows.ui.xaml.media/planeprojection.md)
