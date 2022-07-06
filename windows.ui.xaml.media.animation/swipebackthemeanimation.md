---
-api-id: T:Windows.UI.Xaml.Media.Animation.SwipeBackThemeAnimation
-api-type: winrt class
---

<!-- Class syntax.
public class SwipeBackThemeAnimation : Windows.UI.Xaml.Media.Animation.Timeline, Windows.UI.Xaml.Media.Animation.ISwipeBackThemeAnimation
-->

# Windows.UI.Xaml.Media.Animation.SwipeBackThemeAnimation

## -description
Represents the preconfigured animation that applies to controls when an element slides back into its layout slot after a **Swipe** interaction.



## -xaml-syntax
```xaml
<SwipeBackThemeAnimation ... />
```

## -remarks
Note that setting the [Duration](timeline_duration.md) property has no effect on this object since the duration is preconfigured.

## -examples
The following example applies a [SineEase](sineease.md) easing function to a [DoubleAnimation](doubleanimation.md) to create a decelerating animation.

<!--<p xml:space="preserve">
            <TRANSLATE_MANUALLY>
              <externalLink xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5">
                <linkText>Run this sample</linkText>
                <linkUri>http://go.microsoft.com/fwlink/p/?linkid=139798&amp;sref=SineEase</linkUri>
              </externalLink>
            </TRANSLATE_MANUALLY>
          </p>-->

```xaml
<!-- Example template of a custom control that supports swipe selection.  
     A SwipeBackThemeAnimation is run when the control goes to the Normal state. -->
-->
<ResourceDictionary
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    xmlns:local="using:BlankApp1">

    <Style TargetType="local:SwipeControl" >
        <Setter Property="Template">
            <Setter.Value>
                <ControlTemplate TargetType="local:SwipeControl">
                    <Grid>
                        <VisualStateManager.VisualStateGroups>
                            <VisualStateGroup x:Name="SwipeStates">
                                <VisualState x:Name="Normal">
                                    <Storyboard>
                                        <SwipeBackThemeAnimation TargetName="contentRectangle"/>
                                    </Storyboard>
                                </VisualState>
                                <VisualState x:Name="Selected">
                                    <Storyboard>
                                        <ObjectAnimationUsingKeyFrames Storyboard.TargetName="SelectedText" 
                                            Storyboard.TargetProperty="Visibility">
                                            <DiscreteObjectKeyFrame KeyTime="0" Value="Visible"/>
                                        </ObjectAnimationUsingKeyFrames>
                                    </Storyboard>
                                </VisualState>
                                <VisualState x:Name="Hinting">
                                    <Storyboard>
                                        <SwipeHintThemeAnimation TargetName="contentRectangle"/>
                                    </Storyboard>
                                </VisualState>
                            </VisualStateGroup>
                        </VisualStateManager.VisualStateGroups>
                        <Rectangle Width="100" Height="100" Fill="{TemplateBinding Background}"/>

                        <Rectangle x:Name="contentRectangle"
                            Width="100" 
                            Height="100" 
                            Fill="{TemplateBinding Foreground}"/>
                        <TextBlock x:Name="SelectedText" 
                            Text="Selected" 
                            Visibility="Collapsed" 
                            Foreground="White" 
                            FontSize="20" 
                            VerticalAlignment="Center" 
                            HorizontalAlignment="Center"/>
                    </Grid>
                </ControlTemplate>
            </Setter.Value>
        </Setter>
    </Style>
</ResourceDictionary>
```

```csharp
public sealed class SwipeControl : Control
{
    GestureRecognizer _gestureRecognizer;
    bool _isPointerDown = false;
    bool _isSelected = false;
    bool _isCrossSliding = false;

    public SwipeControl()
    {
        this.DefaultStyleKey = typeof(SwipeControl);
        // Direct gesture recognizer to recognize hold and swipe gestures.
        _gestureRecognizer = new GestureRecognizer();
        _gestureRecognizer.GestureSettings = GestureSettings.Hold | 
                                             GestureSettings.HoldWithMouse | 
                                             GestureSettings.CrossSlide;

        _gestureRecognizer.Holding += GestureRecognizer_Holding;
        _gestureRecognizer.CrossSlideHorizontally = false; // Support vertical swiping.
        _gestureRecognizer.CrossSliding += GestureRecognizer_CrossSliding;            
    }

    protected override void OnPointerPressed(PointerRoutedEventArgs e)
    {
        base.OnPointerPressed(e);
        _isPointerDown = CapturePointer(e.Pointer);
        // Send input to GestureRecognizer for processing.
        _gestureRecognizer.ProcessDownEvent(e.GetCurrentPoint(this));
            
    }

    protected override void OnPointerReleased(PointerRoutedEventArgs e)
    {
        base.OnPointerReleased(e);
        // Send input to GestureRecognizer for processing.
        _gestureRecognizer.ProcessUpEvent(e.GetCurrentPoint(this));

        _isCrossSliding = false;

        // Go to Normal state when pointer is released.
        if (!_isSelected)
        {
            VisualStateManager.GoToState(this, "Normal", true);
        }
    }

    protected override void OnPointerMoved(PointerRoutedEventArgs e)
    {
        base.OnPointerMoved(e);
        if (_isPointerDown)
        {
            // Send input to GestureRecognizer for processing.
            _gestureRecognizer.ProcessMoveEvents(e.GetIntermediatePoints(this));
        }
    }

    void GestureRecognizer_Holding(GestureRecognizer sender, HoldingEventArgs args)
    {
        // Go to Hinting state if control is not already selected.
        if (!_isSelected)
        {
            VisualStateManager.GoToState(this, "Hinting", true);
        }
    }

    void GestureRecognizer_CrossSliding(GestureRecognizer sender, CrossSlidingEventArgs args)
    {
        // Prevent multiple state changes for the same swipe gesture.
        if (!_isCrossSliding)
        {
            _isCrossSliding = true;                
                
            // Toggle between Selected and Normal on swipe gesture.
            _isSelected = !_isSelected;
            if (_isSelected)
            {
                VisualStateManager.GoToState(this, "Selected", true);
            }
            else
            {
                VisualStateManager.GoToState(this, "Normal", true);
            }
        }
    }
}
```

```cppwinrt
// SwipeControl.h:
struct SwipeControl : SwipeControlT<SwipeControl>
{
    SwipeControl();

    void OnPointerPressed(Windows::UI::Xaml::Input::PointerRoutedEventArgs const& e);
    void OnPointerReleased(Windows::UI::Xaml::Input::PointerRoutedEventArgs const& e);
    void OnPointerMoved(Windows::UI::Xaml::Input::PointerRoutedEventArgs const& e);

private:
    Windows::UI::Input::GestureRecognizer m_gestureRecognizer;
    bool m_isPointerDown;
    bool m_isSelected;
    bool m_isCrossSliding;

    void GestureRecognizer_Holding(Windows::UI::Input::GestureRecognizer const& sender, Windows::UI::Input::HoldingEventArgs const& args);
    void GestureRecognizer_CrossSliding(Windows::UI::Input::GestureRecognizer const& sender, Windows::UI::Input::CrossSlidingEventArgs const& args);
};

// SwipeControl.cpp:
SwipeControl::SwipeControl() : m_isCrossSliding(false), m_isPointerDown(false), m_isSelected(false)
{
    DefaultStyleKey(winrt::box_value(L"DocsCppWinRT.SwipeControl"));

    m_gestureRecognizer.GestureSettings(
        Windows::UI::Input::GestureSettings::Hold |
        Windows::UI::Input::GestureSettings::HoldWithMouse |
        Windows::UI::Input::GestureSettings::CrossSlide);

    m_gestureRecognizer.Holding({ this, &SwipeControl::GestureRecognizer_Holding });
    m_gestureRecognizer.CrossSlideHorizontally(false); // Support vertical swiping.
    m_gestureRecognizer.CrossSliding({ this, &SwipeControl::GestureRecognizer_CrossSliding });
}

void SwipeControl::OnPointerPressed(Windows::UI::Xaml::Input::PointerRoutedEventArgs const& e)
{
    m_isPointerDown = CapturePointer(e.Pointer());
    // Send input to GestureRecognizer for processing.
    m_gestureRecognizer.ProcessDownEvent(e.GetCurrentPoint(*this));
}

void SwipeControl::OnPointerReleased(Windows::UI::Xaml::Input::PointerRoutedEventArgs const& e)
{
    // Send input to GestureRecognizer for processing.
    m_gestureRecognizer.ProcessUpEvent(e.GetCurrentPoint(*this));

    m_isCrossSliding = false;

    // Go to Normal state when pointer is released.
    if (!m_isSelected)
    {
        Windows::UI::Xaml::VisualStateManager::GoToState(*this, L"Normal", true);
    }
}

void SwipeControl::OnPointerMoved(Windows::UI::Xaml::Input::PointerRoutedEventArgs const& e)
{
    if (m_isPointerDown)
    {
        // Send input to GestureRecognizer for processing.
        m_gestureRecognizer.ProcessMoveEvents(e.GetIntermediatePoints(*this));
    }
}

void SwipeControl::GestureRecognizer_Holding(Windows::UI::Input::GestureRecognizer const& /* sender */,
    Windows::UI::Input::HoldingEventArgs const& /* args */)
{
    // Go to Hinting state if control is not already selected.
    if (!m_isSelected)
    {
        Windows::UI::Xaml::VisualStateManager::GoToState(*this, L"Hinting", true);
    }
}

void SwipeControl::GestureRecognizer_CrossSliding(Windows::UI::Input::GestureRecognizer const& /* sender */,
    Windows::UI::Input::CrossSlidingEventArgs const& /* args */)
{
    // Prevent multiple state changes for the same swipe gesture.
    if (!m_isCrossSliding)
    {
        m_isCrossSliding = true;

        // Toggle between Selected and Normal on swipe gesture.
        m_isSelected = !m_isSelected;
        if (m_isSelected)
        {
            Windows::UI::Xaml::VisualStateManager::GoToState(*this, L"Selected", true);
        }
        else
        {
            Windows::UI::Xaml::VisualStateManager::GoToState(*this, L"Normal", true);
        }
    }
}
```

```cppcx
// SwipeControl.h:
public ref class SwipeControl sealed : public Windows::UI::Xaml::Controls::Control
{
public:
    SwipeControl();

protected:
    virtual void OnPointerPressed(Windows::UI::Xaml::Input::PointerRoutedEventArgs^ e) override;
    virtual void OnPointerReleased(Windows::UI::Xaml::Input::PointerRoutedEventArgs^ e) override;
    virtual void OnPointerMoved(Windows::UI::Xaml::Input:: PointerRoutedEventArgs^ e) override;

private:
    Windows::UI::Input::GestureRecognizer^     m_gestureRecognizer;
    bool                                       m_isPointerDown;
    bool                                       m_isSelected;
    bool                                       m_isCrossSliding;

    void GestureRecognizer_Holding(Windows::UI::Input::GestureRecognizer^ sender,    
        Windows::UI::Input::HoldingEventArgs^ args);
    void GestureRecognizer_CrossSliding(Windows::UI::Input::GestureRecognizer^ sender, 
        Windows::UI::Input::CrossSlidingEventArgs^ args);
};

// SwipeControl.cpp:
SwipeControl::SwipeControl() : m_isCrossSliding(false), m_isPointerDown(false), m_isSelected(false)
{
    DefaultStyleKey = "DocsCPP.SwipeControl";

    m_gestureRecognizer = ref new GestureRecognizer();
    m_gestureRecognizer->GestureSettings = GestureSettings::Hold | 
                                              GestureSettings::HoldWithMouse | 
                                              GestureSettings::CrossSlide;

    m_gestureRecognizer->Holding::add(ref new TypedEventHandler<GestureRecognizer^, 
        HoldingEventArgs^>(this, &SwipeControl::GestureRecognizer_Holding));
    m_gestureRecognizer->CrossSlideHorizontally = false; // Support vertical swiping.
    m_gestureRecognizer->CrossSliding::add(ref new TypedEventHandler<GestureRecognizer^, 
        CrossSlidingEventArgs^>(this, &SwipeControl::GestureRecognizer_CrossSliding));
}

void SwipeControl::OnPointerPressed(PointerRoutedEventArgs^ e)
{
    m_isPointerDown = CapturePointer(e->Pointer);
    // Send input to GestureRecognizer for processing.
    m_gestureRecognizer->ProcessDownEvent(e->GetCurrentPoint(this));
}

void SwipeControl::OnPointerReleased(PointerRoutedEventArgs^ e)
{
    // Send input to GestureRecognizer for processing.
    m_gestureRecognizer->ProcessUpEvent(e->GetCurrentPoint(this));

    m_isCrossSliding = false;

    // Go to Normal state when pointer is released.
    if (!m_isSelected)
    {
        VisualStateManager::GoToState(this, "Normal", true);
    }
}

void SwipeControl::OnPointerMoved(PointerRoutedEventArgs^ e)
{
    if (m_isPointerDown)
    {
        // Send input to GestureRecognizer for processing.
        m_gestureRecognizer->ProcessMoveEvents(e->GetIntermediatePoints(this));
    }
}

void SwipeControl::GestureRecognizer_Holding(GestureRecognizer^ sender, HoldingEventArgs^ args)
{
    // Go to Hinting state if control is not already selected.
    if (!m_isSelected)
    {
        VisualStateManager::GoToState(this, "Hinting", true);
    }
}

void SwipeControl::GestureRecognizer_CrossSliding(GestureRecognizer^ sender, CrossSlidingEventArgs^ args)
{
    // Prevent multiple state changes for the same swipe gesture.
    if (!m_isCrossSliding)
    {
        m_isCrossSliding = true;                
                
        // Toggle between Selected and Normal on swipe gesture.
        m_isSelected = !m_isSelected;
        if (m_isSelected)
        {
            VisualStateManager::GoToState(this, "Selected", true);
        }
        else
        {
            VisualStateManager::GoToState(this, "Normal", true);
        }
    } 
}
```

## -see-also
[Timeline](timeline.md), [Animating swipe gestures](/previous-versions/windows/apps/jj649435(v=win.10))
