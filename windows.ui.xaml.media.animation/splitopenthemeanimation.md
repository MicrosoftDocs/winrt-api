---
-api-id: T:Windows.UI.Xaml.Media.Animation.SplitOpenThemeAnimation
-api-type: winrt class
---

<!-- Class syntax.
public class SplitOpenThemeAnimation : Windows.UI.Xaml.Media.Animation.Timeline, Windows.UI.Xaml.Media.Animation.ISplitOpenThemeAnimation
-->

# Windows.UI.Xaml.Media.Animation.SplitOpenThemeAnimation

## -description
Represents the preconfigured animation that reveals a target UI using a *split* animation.



## -xaml-syntax
```xaml
<SplitOpenThemeAnimation .../>
```

## -remarks
Note that setting the [Duration](timeline_duration.md) property has no effect on this object since the duration is preconfigured.

## -examples
The following is an example of a custom control that uses split open and split close theme animations.

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
<!-- Example template of a custom control that uses split open 
     and split close theme animations. -->
<ResourceDictionary
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    xmlns:local="using:BlankApp1">

    <Style TargetType="local:SplitOpenControl" >
        <Setter Property="Template">
            <Setter.Value>
                <ControlTemplate TargetType="local:SplitOpenControl">
                    <Grid>
                        <VisualStateManager.VisualStateGroups>
                            <VisualStateGroup x:Name="OpenStates">
                                <VisualState x:Name="Open">
                                    <Storyboard>
                                        <SplitOpenThemeAnimation 
                                            OpenedTargetName="contentBorder" 
                                            ContentTargetName="content" 
                                            ClosedTargetName="targetRect"
                                            ContentTranslationDirection="Left"
                                            ContentTranslationOffset="200"  
                                            OffsetFromCenter="0"
                                            OpenedLength="200"
                                            ClosedLength="0"/>
                                        <DoubleAnimation 
                                            Storyboard.TargetName="targetRect" 
                                            Storyboard.TargetProperty="Opacity" 
                                            To="0" 
                                            Duration="0"/>
                                    </Storyboard>
                                </VisualState>
                                <VisualState x:Name="Closed">
                                    <Storyboard>
                                        <SplitCloseThemeAnimation
                                            OpenedTargetName="contentBorder" 
                                            ContentTargetName="content" 
                                            ClosedTargetName="targetRect"
                                            ContentTranslationDirection="Left"
                                            ContentTranslationOffset="-200"  
                                            OffsetFromCenter="0"
                                            OpenedLength="200"
                                            ClosedLength="0"/>
                                    </Storyboard>
                                </VisualState>
                            </VisualStateGroup>
                        </VisualStateManager.VisualStateGroups>

                        <Rectangle x:Name="targetRect" Width="100" Height="100" Fill="Blue"/>

                        <Popup IsOpen="False" Height="50" Width="200" x:Name="contentPopup">
                            <Border x:Name="contentBorder" BorderBrush="Orange" BorderThickness="3">
                                <TextBlock x:Name="content" Text="Hello, World!" FontSize="20"/>
                            </Border>
                        </Popup>
                    </Grid>
                </ControlTemplate>
            </Setter.Value>
        </Setter>
    </Style>
</ResourceDictionary>
```

```csharp
public sealed class SplitOpenControl : Control
{
    private Popup _contentPopup;
    public SplitOpenControl()
    {
        this.DefaultStyleKey = typeof(SplitOpenControl);
    }

    protected override void OnApplyTemplate()
    {
        base.OnApplyTemplate();
        _contentPopup = GetTemplateChild("contentPopup") as Popup;
    }

    protected override void OnPointerPressed(PointerRoutedEventArgs e)
    {
        this.CapturePointer(e.Pointer);
        _contentPopup.IsOpen = true;
        VisualStateManager.GoToState(this, "Open", true);            
    }

    protected override void OnPointerReleased(PointerRoutedEventArgs e)
    {            
        VisualStateManager.GoToState(this, "Closed", true);
        this.ReleasePointerCapture(e.Pointer);
    }
}
```

```cppwinrt
// SplitOpenControl.h:
struct SplitOpenControl : SplitOpenControlT<SplitOpenControl>
{
    SplitOpenControl(){ DefaultStyleKey(winrt::box_value(L"MyApp.SplitOpenControl")); }

    void OnApplyTemplate();
    void OnPointerPressed(Windows::UI::Xaml::Input::PointerRoutedEventArgs const& e);
    void OnPointerReleased(Windows::UI::Xaml::Input::PointerRoutedEventArgs const& e);

private:
    Windows::UI::Xaml::Controls::Primitives::Popup m_contentPopup;
};

// SplitOpenControl.cpp:
void SplitOpenControl::OnApplyTemplate()
{
    m_contentPopup = GetTemplateChild(L"contentPopup").as<Windows::UI::Xaml::Controls::Primitives::Popup>();
}

void SplitOpenControl::OnPointerPressed(Windows::UI::Xaml::Input::PointerRoutedEventArgs const& e)
{
    CapturePointer(e.Pointer());
    m_contentPopup.IsOpen(true);
    Windows::UI::Xaml::VisualStateManager::GoToState(*this, L"Open", true);
}

void SplitOpenControl::OnPointerReleased(Windows::UI::Xaml::Input::PointerRoutedEventArgs const& e)
{
    Windows::UI::Xaml::VisualStateManager::GoToState(*this, L"Closed", true);
    ReleasePointerCapture(e.Pointer());
}
```

```cppcx
// SplitOpenControl.h:
public ref class SplitOpenControl sealed : public Windows::UI::Xaml::Controls::Control
{
public:
    SplitOpenControl();
protected:
    virtual void OnApplyTemplate() override;
    virtual void OnPointerPressed(Windows::UI::Xaml::Input::PointerRoutedEventArgs^ e) override;
    virtual void OnPointerReleased(Windows::UI::Xaml::Input::PointerRoutedEventArgs^ e) override;
private:
    Windows::UI::Xaml::Controls::Primitives::Popup ^m_contentPopup;
};

// SplitOpenControl.cpp:
SplitOpenControl::SplitOpenControl()
{
    DefaultStyleKey = "MyApp.SplitOpenControl";
}

void SplitOpenControl::OnApplyTemplate()
{
    m_contentPopup = static_cast<Popup^>(GetTemplateChild("contentPopup"));
}

void SplitOpenControl::OnPointerPressed(PointerRoutedEventArgs^ e)
{
    CapturePointer(e->Pointer);
    m_contentPopup->IsOpen = true;
    VisualStateManager::GoToState(this, "Open", true);
}

void SplitOpenControl::OnPointerReleased(PointerRoutedEventArgs^ e)
{
    VisualStateManager::GoToState(this, "Closed", true);
    ReleasePointerCapture(e->Pointer);
}
```

## -see-also
[Timeline](timeline.md)
