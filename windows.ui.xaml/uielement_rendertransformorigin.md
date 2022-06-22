---
-api-id: P:Windows.UI.Xaml.UIElement.RenderTransformOrigin
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Point RenderTransformOrigin { get;  set; }
-->

# Windows.UI.Xaml.UIElement.RenderTransformOrigin

## -description
Gets or sets the origin point of any possible render transform declared by [RenderTransform](uielement_rendertransform.md), relative to the bounds of the [UIElement](uielement.md).



## -xaml-syntax
```xaml
<uiElement RenderTransformOrigin="x,y"/>
```


## -xaml-values
<dl><dt>x</dt><dd>xThe X value of the Point that specifies the transform origin. Typically this is between 0 and 1.</dd>
<dt>y</dt><dd>yThe Yvalue of a Point that specifies the transform origin. Typically this is between 0 and 1.</dd>
</dl>
## -property-value
The origin point of the render transform. The default value is a [Point](../windows.foundation/point.md) with value 0,0.

## -remarks
RenderTransformOrigin enables you to create or change the effect of a transform on a particular element without having to alter the specifics of the [RenderTransform](uielement_rendertransform.md) transform. The [Point](../windows.foundation/point.md) value you specify for RenderTransformOrigin is not based on actual pixel measures. Instead, it is a *logical point*, where a value of 0,0 refers to the top left corner of the overall [UIElement](uielement.md) render area, and 1,1 refers to the bottom right. The value is then evaluated into an X,Y coordinate by factoring it into the current coordinate space of the [UIElement](uielement.md).

For some transforms, the origin doesn't matter. For example the RenderTransformOrigin won't change the behavior of a [TranslateTransform](../windows.ui.xaml.media/translatetransform.md) applied to the [RenderTransform](uielement_rendertransform.md) property.

Some transform types have their own properties for specifying the origin of the transform. For example, [RotateTransform](../windows.ui.xaml.media/rotatetransform.md) has [CenterX](../windows.ui.xaml.media/rotatetransform_centerx.md) and [CenterY](../windows.ui.xaml.media/rotatetransform_centery.md). When you're working with a [UIElement](uielement.md), visual design tools sometimes hide these other properties so that you only use RenderTransformOrigin for all transform origin changes and leave transform-specific origins as the defaults. Tools might also apply all transform effects to a single [CompositeTransform](../windows.ui.xaml.media/compositetransform.md) value for [RenderTransform](uielement_rendertransform.md), rather than defining XAML elements for the specific transforms and making a [TransformGroup](../windows.ui.xaml.media/transformgroup.md). If you're writing your own XAML or defining transforms in code, you might consider following these same practices so that you always use RenderTransformOrigin rather than the transform-specific origin values if you're applying transforms for [RenderTransform](uielement_rendertransform.md), otherwise the values will offset each other.

A common technique is to set RenderTransformOrigin to 0.5,0.5, which places the origin at the element center. You could then apply a [RotateTransform](../windows.ui.xaml.media/rotatetransform.md) to rotate the element around the center.

Changing [FlowDirection](frameworkelement_flowdirection.md) to **RightToLeft** changes the meaning of the X coordinate of a RenderTransformOrigin for a [UIElement](uielement.md); 0 will be the right edge.

Some of the same visual effects that you can produce with [RenderTransform](uielement_rendertransform.md) and RenderTransformOrigin can also be achieved with [Projection](uielement_projection.md) and a [PlaneProjection](../windows.ui.xaml.media/planeprojection.md). For example, you can rotate a [UIElement](uielement.md) around its center by changing [PlaneProjection.RotationZ](../windows.ui.xaml.media/planeprojection_rotationz.md).

## -examples
This XAML example shows how to set RenderTransformOrigin on the element in the initial XAML. An animation that runs on an initially default [CompositeTransform](../windows.ui.xaml.media/compositetransform.md) can use the RenderTransformOrigin to modify both the scale and rotate transforms to apply to the circles's center rather than the default 0,0 coordinate origin. This makes it appear as if the circle is spinning around its center and shrinking in place. 

> [!NOTE]
> To start the animation you'd need to retrieve it from [Resources](frameworkelement_resources.md) and call [Begin](../windows.ui.xaml.media.animation/storyboard_begin_1621727531.md); that code is not shown.

```xaml
        <Ellipse x:Name="e1" RenderTransformOrigin=".5,.5" Height="100" Width="100" Loaded="e1_Loaded_1">
            <Ellipse.Fill>
                <LinearGradientBrush>
                    <GradientStop Color="Red" Offset="0"/>
                    <GradientStop Color="Green" Offset="1"/>
                </LinearGradientBrush>
            </Ellipse.Fill>
            <Ellipse.RenderTransform>
                <CompositeTransform />
            </Ellipse.RenderTransform>
            <Ellipse.Resources>
                <Storyboard x:Name="esb1" >
                    <DoubleAnimation RepeatBehavior="3x" Duration="0:0:3" From="0" To="360" Storyboard.TargetName="e1" 
                      Storyboard.TargetProperty="(UIElement.RenderTransform).(CompositeTransform.Rotation)" />
                    <DoubleAnimation RepeatBehavior="1x" Duration="0:0:7" From="1" To="0" Storyboard.TargetName="e1" 
                      Storyboard.TargetProperty="(UIElement.RenderTransform).(CompositeTransform.ScaleX)" />
                    <DoubleAnimation RepeatBehavior="1x" Duration="0:0:7" From="1" To="0" Storyboard.TargetName="e1" 
                      Storyboard.TargetProperty="(UIElement.RenderTransform).(CompositeTransform.ScaleY)" />
                </Storyboard>
            </Ellipse.Resources>
        </Ellipse>
```



## -see-also
[TranslateTransform](../windows.ui.xaml.media/translatetransform.md), [3-D effects for  using XAML](/previous-versions/windows/apps/hh700359(v=win.10)), [XAML two-dimensional transforms sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/XAML%20two-dimensional%20transforms%20sample)
