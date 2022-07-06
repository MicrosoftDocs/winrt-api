---
-api-id: T:Windows.UI.Xaml.Media.Animation.PopInThemeAnimation
-api-type: winrt class
---

<!-- Class syntax.
public class PopInThemeAnimation : Windows.UI.Xaml.Media.Animation.Timeline, Windows.UI.Xaml.Media.Animation.IPopInThemeAnimation
-->

# Windows.UI.Xaml.Media.Animation.PopInThemeAnimation

## -description
Represents the preconfigured animation that applies to pop-in components of controls (for example, tooltip-like UI on an object) as they appear. This animation combines opacity and translation.



## -xaml-syntax
```xaml
<PopInThemeAnimation .../>
```


## -remarks
This animation does not move or change the object or its neighbors. This animation is meant to be applied to overlay content (like tooltips) when that content first appears. When the content dissapears, you should use a [PopOutThemeAnimation](popoutthemeanimation.md).

Note that setting the [Duration](timeline_duration.md) property has no effect on this object since the duration is preconfigured.

## -examples
The following shows an example template for a [ToolTip](../windows.ui.xaml.controls/tooltip.md) control that uses PopInThemeAnimation and [PopOutThemeAnimation](popoutthemeanimation.md).

```xaml
<Style x:Key="ToolTipStyle1" TargetType="ToolTip">
    <!-- Sample template for the ToolTip control that uses PopinThemeAnimation and PopOutThemeAnimation. -->
    <Setter Property="Template">
        <Setter.Value>
            <ControlTemplate TargetType="ToolTip">
                <Border x:Name="LayoutRoot" 
                         BorderBrush="{TemplateBinding BorderBrush}" 
                         BorderThickness="{TemplateBinding BorderThickness}" 
                         Background="{TemplateBinding Background}">
                    <VisualStateManager.VisualStateGroups>
                        <VisualStateGroup x:Name="OpenStates">
                            <VisualState x:Name="Closed">
                                <Storyboard>
                                    <!-- Run a PopOutThemeAnimation when ToolTip is closed. -->
                                    <PopOutThemeAnimation TargetName="LayoutRoot"/>
                                </Storyboard>
                            </VisualState>
                            <VisualState x:Name="Opened">
                                <Storyboard>
                                    <!-- Run a PopInThemeAnimation when ToolTip is opened. -->
                                    <PopInThemeAnimation 
                                        FromVerticalOffset="{Binding TemplateSettings.FromVerticalOffset, RelativeSource={RelativeSource Mode=TemplatedParent}}" 
                                        FromHorizontalOffset="{Binding TemplateSettings.FromHorizontalOffset, RelativeSource={RelativeSource Mode=TemplatedParent}}" 
                                        TargetName="LayoutRoot"/>
                                </Storyboard>
                            </VisualState>
                        </VisualStateGroup>
                    </VisualStateManager.VisualStateGroups>
                    <ContentPresenter 
                         ContentTemplate="{TemplateBinding ContentTemplate}" 
                         ContentTransitions="{TemplateBinding ContentTransitions}" 
                         Content="{TemplateBinding Content}" 
                         Margin="{TemplateBinding Padding}"/>
                </Border>
            </ControlTemplate>
        </Setter.Value>
    </Setter>
</Style>

```



## -see-also
[Timeline](timeline.md), [Animating pop-up UI](/previous-versions/windows/apps/jj649433(v=win.10)), [Guidelines and checklist for pop-up UI animations](/windows/uwp/style/motion-popup-animations)
