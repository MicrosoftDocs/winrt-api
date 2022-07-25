---
-api-id: P:Windows.UI.Xaml.FrameworkElement.Triggers
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.TriggerCollection Triggers { get; }
-->

# Windows.UI.Xaml.FrameworkElement.Triggers

## -description
Gets the collection of triggers for animations that are defined for a [FrameworkElement](frameworkelement.md). Not commonly used. See Remarks.



## -xaml-syntax
```xaml
<frameworkElement>
  <frameworkElement.Triggers>
    oneorMoreTriggers
  </frameworkElement.Triggers>
</frameworkElement>
```


## -xaml-values
<dl><dt>oneorMoreTriggers</dt><dd>oneorMoreTriggersOne or more object elements of type EventTrigger.</dd>
</dl>
## -property-value
The collection of triggers for animations that are defined for this object.

## -remarks
Triggers, [EventTrigger](eventtrigger.md), [Actions](eventtrigger_actions.md) and [BeginStoryboard](../windows.ui.xaml.media.animation/beginstoryboard.md) are not commonly used. These API mainly exist for compatibility in XAML originally used for Microsoft Silverlight. For most scenarios where event triggers were used previously, you should use built-in animations, visual states, or start animations by writing a [Loaded](frameworkelement_loaded.md) handler that looks up an animation in page-level resources and then calls [Begin](../windows.ui.xaml.media.animation/storyboard_begin_1621727531.md) on the animation's main [Storyboard](../windows.ui.xaml.media.animation/storyboard.md). For more info, see [Quickstart: Control templates](/previous-versions/windows/apps/hh465374(v=win.10)) or [Storyboarded animations](/windows/uwp/graphics/storyboarded-animations).

## -examples
This XAML example shows the basic structure for using FrameworkElement.Triggers with its default [FrameworkElement.Loaded](frameworkelement_loaded.md) trigger behavior to run a storyboarded animation. This XAML shows the [EventTrigger](eventtrigger.md) and [BeginStoryboard](../windows.ui.xaml.media.animation/beginstoryboard.md) container elements in proper relationship with each using their XAML content property syntax and unnecessary property element tags omitted.

```xaml
<Canvas Width="200" Height="200" x:Name="animatedcanvas" Background="Red">
    <Canvas.Triggers>
        <EventTrigger>
            <BeginStoryboard>
                <Storyboard x:Name="ColorStoryboard">
                   <!-- Animate the background of the canvas to green over 4 seconds. -->
                    <ColorAnimation Storyboard.TargetName="animatedcanvas"
                      Storyboard.TargetProperty="(Panel.Background).(SolidColorBrush.Color)"
                      To="Green" Duration="0:0:4" />
                </Storyboard>
            </BeginStoryboard>
        </EventTrigger>
    </Canvas.Triggers>
</Canvas>
```



## -see-also
[Storyboard](../windows.ui.xaml.media.animation/storyboard.md)
