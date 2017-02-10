---
-api-id: E:Windows.UI.Xaml.UIElement.LostFocus
-api-type: winrt event
---

<!-- Event syntax
public event Windows.UI.Xaml.RoutedEventHandler LostFocus
-->

# Windows.UI.Xaml.UIElement.LostFocus

## -description
Occurs when a [UIElement](uielement.md) loses focus.

## -xaml-syntax
```xaml
<uiElement LostFocus="eventhandler"/>
```


## -remarks
The typical reason that a control loses focus is that another control now has focus. But there are other possible reasons for losing focus, such as switching to another view state or another app, or the user interacting with the system in other ways.

Keyboard focus is particularly relevant for keyboard event handling, because only the currently keyboard-focused [UIElement](uielement.md) can be the source of the key events [KeyUp](uielement_keyup.md) and [KeyDown](uielement_keydown.md). In some scenarios, apps deliberately call [Focus](../windows.ui.xaml.controls/control_focus.md) as an initialization action so that the key events in the app as a whole can be used to detect access or accelerator keys. For more info, see [Keyboard interactions](http://msdn.microsoft.com/library/ff819bac-67c0-4ec9-8921-f087be188138).

[LostFocus](uielement_lostfocus.md) is a routed event. For more info on the routed event concept, see [Events and routed events overview](http://msdn.microsoft.com/library/34c219e8-3efb-45bc-8bbd-6fd937698832).

Specific Windows Runtime controls may have class-based handling for the [LostFocus](uielement_lostfocus.md) event. If so, the control probably has an override for the method [OnLostFocus](../windows.ui.xaml.controls/control_onlostfocus.md). Typically the event is marked handled by the class handler, and the [LostFocus](uielement_lostfocus.md) event is not raised for handling by any user code handlers on that control. Controls might handle the event in order to unload a visual state that displayed a focus rectangle in response to [OnGotFocus](../windows.ui.xaml.controls/control_ongotfocus.md). A focus rectangle is an important visual component of a control for accessibility purposes, so that users can see where the current focused element is in the UI and where the user is within the tab sequence of the overall app UI. For more info on how class-based handling for events works, see [Events and routed events overview](http://msdn.microsoft.com/library/34c219e8-3efb-45bc-8bbd-6fd937698832). For more info on tab sequences and accessibility, see [Keyboard accessibility](http://msdn.microsoft.com/library/ddae8c4b-7907-49fe-9645-f105f8dfad8b).

## -examples

## -see-also
[GotFocus](uielement_gotfocus.md), [Control.Focus](../windows.ui.xaml.controls/control_focus.md), [Keyboard interactions](http://msdn.microsoft.com/library/ff819bac-67c0-4ec9-8921-f087be188138), [Storyboarded animations for visual states](http://msdn.microsoft.com/library/5e715281-d247-4e7f-9f88-2af0d88ed5e4)