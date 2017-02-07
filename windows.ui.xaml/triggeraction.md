---
-api-id: T:Windows.UI.Xaml.TriggerAction
-api-type: winrt class
---

<!-- Class syntax.
public class TriggerAction : Windows.UI.Xaml.DependencyObject, Windows.UI.Xaml.ITriggerAction
-->

# Windows.UI.Xaml.TriggerAction

## -description
Serves as the base class for [BeginStoryboard](../windows.ui.xaml.media.animation/beginstoryboard.md). Not commonly used. See Remarks.

## -remarks
[Triggers](frameworkelement_triggers.md), [EventTrigger](eventtrigger.md), [Actions](eventtrigger_actions.md) and [BeginStoryboard](../windows.ui.xaml.media.animation/beginstoryboard.md) are not commonly used. These API mainly exist for compatibility in XAML originally used for Microsoft Silverlight. For most scenarios where event triggers were used previously, you should either use visual states, or start animations by writing a [Loaded](frameworkelement_loaded.md) handler that looks up an animation in page-level resources and then calls [Begin](../windows.ui.xaml.media.animation/storyboard_begin.md) on the animation's main [Storyboard](../windows.ui.xaml.media.animation/storyboard.md). For more info, see [Quickstart: Control templates](http://msdn.microsoft.com/library/67c424ae-afb1-4560-a6a8-4a3506775d77) or [Storyboarded animations](http://msdn.microsoft.com/library/0cbceea0-2b0e-44a1-a09a-f7a939632f3a).

## -examples

## -see-also
[DependencyObject](dependencyobject.md)