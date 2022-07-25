---
-api-id: T:Windows.UI.Xaml.Media.Animation.DragItemThemeAnimation
-api-type: winrt class
---

<!-- Class syntax.
public class DragItemThemeAnimation : Windows.UI.Xaml.Media.Animation.Timeline, Windows.UI.Xaml.Media.Animation.IDragItemThemeAnimation
-->

# Windows.UI.Xaml.Media.Animation.DragItemThemeAnimation

## -description
Represents the preconfigured animation that applies to item elements being dragged.



## -xaml-syntax
```xaml
<DragItemThemeAnimation .../>
```

## -remarks
Note that setting the [Duration](timeline_duration.md) property has no effect on this object since the duration is preconfigured.

## -examples
The following is an example of a drag-enabled custom control.

<!--<p xml:space="preserve">
            <TRANSLATE_MANUALLY>
              <externalLink xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5">
                <linkText>Run this sample</linkText>
                <linkUri>http://go.microsoft.com/fwlink/p/?linkid=139798&amp;sref=SineEase</linkUri>
              </externalLink>
            </TRANSLATE_MANUALLY>
          </p>-->

```xaml
// Themes/Generic.xaml
<!-- Example template of a drag-enabled custom control. The
     DragItemThemeAnimation will be run when the control
     is in the Dragging state, and reverted when it isn't.
-->
<ResourceDictionary
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    xmlns:local="using:BlankApp1">

    <Style TargetType="local:DraggableControl" >
        <Setter Property="Template">
            <Setter.Value>
                <ControlTemplate TargetType="local:DraggableControl">
                    <Grid>
                        <VisualStateManager.VisualStateGroups>
                            <VisualStateGroup x:Name="DragStates">
                                <VisualState x:Name="NotDragging"/>
                                <VisualState x:Name="Dragging">
                                    <Storyboard>
                                        <DragItemThemeAnimation TargetName="contentRectangle"/>
                                    </Storyboard>
                                </VisualState>
                            </VisualStateGroup>
                        </VisualStateManager.VisualStateGroups>
                        <Rectangle x:Name="contentRectangle" Width="100" Height="100" Fill="{TemplateBinding Background}"/>
                    </Grid>
                </ControlTemplate>
            </Setter.Value>
        </Setter>
    </Style>
</ResourceDictionary>
```

```csharp
public sealed class DraggableControl : Control
{
    public DraggableControl()
    {
        this.DefaultStyleKey = typeof(DraggableControl);
    }

    protected override void OnPointerPressed(PointerRoutedEventArgs e)
    {
        // Go to the Dragging state, which will start the DragItemThemeAnimation.
        VisualStateManager.GoToState(this, "Dragging", true);
    }

    protected override void OnPointerReleased(PointerRoutedEventArgs e)
    {
        VisualStateManager.GoToState(this, "NotDragging", true);
    }

    protected override void OnPointerMoved(PointerRoutedEventArgs e)
    {
        // dragging implementation here.
    }
}
```

```cppwinrt
// DraggableControl.h
struct DraggableControl : DraggableControlT<DraggableControl>
{
    DraggableControl(){ DefaultStyleKey(winrt::box_value(L"MyApp.DraggableControl")); }

    void OnPointerPressed(Windows::UI::Xaml::Input::PointerRoutedEventArgs const& e);
    void OnPointerReleased(Windows::UI::Xaml::Input::PointerRoutedEventArgs const& e);
    void OnPointerMoved(Windows::UI::Xaml::Input::PointerRoutedEventArgs const& e);
};

// DraggableControl.cpp
void DraggableControl::OnPointerPressed(Windows::UI::Xaml::Input::PointerRoutedEventArgs const& e)
{
    // Go to the Dragging state, which will start the DragItemThemeAnimation.
    Windows::UI::Xaml::VisualStateManager::GoToState(*this, L"Dragging", true);
}

void DraggableControl::OnPointerReleased(Windows::UI::Xaml::Input::PointerRoutedEventArgs const& e)
{
    Windows::UI::Xaml::VisualStateManager::GoToState(*this, L"NotDragging", true);
}

void DraggableControl::OnPointerMoved(Windows::UI::Xaml::Input::PointerRoutedEventArgs const& e)
{
    // dragging implementation here.
}
```

```cppcx
// DraggableControl.h:
public ref class DraggableControl sealed : public Windows::UI::Xaml::Controls::Control
{
public:
    DraggableControl();
protected:
    virtual void OnPointerPressed(Windows::UI::Xaml::Input::PointerRoutedEventArgs^ e) override;
    virtual void OnPointerReleased(Windows::UI::Xaml::Input::PointerRoutedEventArgs^ e) override;
    virtual void OnPointerMoved(Windows::UI::Xaml::Input:: PointerRoutedEventArgs^ e) override;
};

// DraggableControl.cpp:
DraggableControl::DraggableControl()
{
    DefaultStyleKey = "MyApp.DraggableControl";
}

void DraggableControl::OnPointerPressed(PointerRoutedEventArgs^ e)
{
    // Go to the Dragging state, which will start the DragItemThemeAnimation
    VisualStateManager::GoToState(this, "Dragging", true);
}

void DraggableControl::OnPointerReleased(PointerRoutedEventArgs^ e)
{
    VisualStateManager::GoToState(this, "NotDragging", true);
}

void DraggableControl::OnPointerMoved(PointerRoutedEventArgs^ e)
{
    // dragging implementation here
}
```

## -see-also
[Timeline](timeline.md), [Animating drag-and-drop sequences](/previous-versions/windows/apps/jj649427(v=win.10)), [Guidelines and checklist for drag-and-drop animations](/windows/uwp/style/motion-dragdrop)
