---
-api-id: T:Windows.UI.Xaml.Media.Animation.PointerUpThemeAnimation
-api-type: winrt class
---

<!-- Class syntax.
public class PointerUpThemeAnimation : Windows.UI.Xaml.Media.Animation.Timeline, Windows.UI.Xaml.Media.Animation.IPointerUpThemeAnimation
-->

# Windows.UI.Xaml.Media.Animation.PointerUpThemeAnimation

## -description
Represents a preconfigured animation that runs after a pointer down is detected on an item or element and the tap action is released.

## -xaml-syntax
```xaml
<PointerUpThemeAnimation .../>
```


## -remarks
Setting the [Duration](timeline_duration.md) property has no effect on this object as the duration is preconfigured.

[PointerUpThemeAnimation](pointerupthemeanimation.md) overrides the current values of [Projection](../windows.ui.xaml/uielement_projection.md) and [RenderTransform](../windows.ui.xaml/uielement_rendertransform.md) and sets them to their default values.

> **Windows 8.1 and prior**
> [Projection](../windows.ui.xaml/uielement_projection.md) and [RenderTransform](../windows.ui.xaml/uielement_rendertransform.md) are not affected by [PointerDownThemeAnimation](pointerdownthemeanimation.md).

## -examples
The following is an example of a template of a custom control that uses PointerDown/Up theme animations.

```xaml

<!-- Example template of a custom control that uses PointerDown/Up theme animations.
     The PointerUpThemeAnimation will be run when the control is in the PointerUp 
     state. -->
<ControlTemplate TargetType="local:TapControl">
    <Grid>
        <VisualStateManager.VisualStateGroups>
            <VisualStateGroup x:Name="TapStates">
                <VisualState x:Name="Normal"/>
                <VisualState x:Name="PointerDown">
                    <Storyboard>
                        <PointerDownThemeAnimation TargetName="contentRectangle"/>
                    </Storyboard>
                </VisualState>    
                <VisualState x:Name="PointerUp">
                    <Storyboard>
                        <PointerUpThemeAnimation TargetName="contentRectangle"/>
                    </Storyboard>
                </VisualState>
            </VisualStateGroup>
        </VisualStateManager.VisualStateGroups>
        <Rectangle x:Name="contentRectangle" 
                    Width="100" 
                    Height="100" 
                    Fill="{TemplateBinding Background}"/>
    </Grid>
</ControlTemplate>

```

```csharp
public sealed class TapControl : Control
{
    public TapControl()
    {
        this.DefaultStyleKey = typeof(TapControl);
    }

    protected override void OnPointerPressed(PointerRoutedEventArgs e)
    {
        this.CapturePointer(e.Pointer);
        VisualStateManager.GoToState(this, "PointerDown", true);
    }

    protected override void OnPointerReleased(PointerRoutedEventArgs e)
    {
        VisualStateManager.GoToState(this, "PointerUp", true);
        this.ReleasePointerCapture(e.Pointer);
    }
}
```

```cpp
// TapControl.h:
public ref class TapControl sealed : public Windows::UI::Xaml::Controls::Control
{
public:
    TapControl();
protected:
    virtual void OnPointerPressed(Windows::UI::Xaml::Input::PointerRoutedEventArgs^ e) override;
    virtual void OnPointerReleased(Windows::UI::Xaml::Input::PointerRoutedEventArgs^ e) override;
};

// TapControl.cpp:
TapControl::TapControl()
{
    DefaultStyleKey = "MyApp.TapControl";
}

void SplitOpenControl::OnPointerPressed(PointerRoutedEventArgs^ e)
{
    CapturePointer(e->Pointer);
    VisualStateManager::GoToState(this, "PointerDown", true);
}

void SplitOpenControl::OnPointerReleased(PointerRoutedEventArgs^ e)
{
    VisualStateManager::GoToState(this, "PointerUp", true);
    ReleasePointerCapture(e->Pointer);
}
```



## -see-also
[Timeline](timeline.md), [Animating pointer clicks](http://msdn.microsoft.com/library/b100b9c1-dfd7-43ac-99ed-a742a029c39b), [Guidelines and checklist for pointer click animations](http://msdn.microsoft.com/library/eeb10a2c-629a-4705-8468-4d019d74ddff)