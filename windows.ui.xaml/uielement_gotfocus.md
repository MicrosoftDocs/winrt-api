---
-api-id: E:Windows.UI.Xaml.UIElement.GotFocus
-api-type: winrt event
---

<!-- Event syntax
public event Windows.UI.Xaml.RoutedEventHandler GotFocus
-->

# Windows.UI.Xaml.UIElement.GotFocus

## -description
Occurs when a [UIElement](uielement.md) receives focus.

## -xaml-syntax
```xaml
<uiElement GotFocus="eventhandler"/>
```


## -remarks
Only one element at a time in a page of UI can have focus.

If you are using control compositing or UI compositing and handling [GotFocus](uielement_gotfocus.md) on a container such as a [Panel](../windows.ui.xaml.controls/panel.md) or [GridView](../windows.ui.xaml.controls/gridview.md), then you might want to check the [OriginalSource](routedeventargs_originalsource.md) on the event data to determine which element in the composition actually received the focus.

[GotFocus](uielement_gotfocus.md) doesn't have any specialized event data. For many scenarios where you handle [GotFocus](uielement_gotfocus.md), you might want to determine whether it was the user or app code that caused an element to gain focus. To determine this in your handler, cast the *sender* of the event to be a [Control](../windows.ui.xaml.controls/control.md) object, and check the [FocusState](../windows.ui.xaml.controls/control_focusstate.md).

Keyboard focus is particularly relevant for keyboard event handling, because only the currently keyboard-focused [UIElement](uielement.md) can be the source of the key events [KeyUp](uielement_keyup.md) and [KeyDown](uielement_keydown.md). In some scenarios, apps deliberately call [Focus](../windows.ui.xaml.controls/control_focus.md) as an initialization action so that the key events in the app as a whole can be used to detect access or accelerator keys. For more info, see [Keyboard interactions](http://msdn.microsoft.com/library/ff819bac-67c0-4ec9-8921-f087be188138).

[GotFocus](uielement_gotfocus.md) is a routed event. For more info on the routed event concept, see [Events and routed events overview](http://msdn.microsoft.com/library/34c219e8-3efb-45bc-8bbd-6fd937698832).

Specific Windows Runtime controls may have class-based handling for the [GotFocus](uielement_gotfocus.md) event. If so, the control probably has an override for the method [OnGotFocus](../windows.ui.xaml.controls/control_ongotfocus.md). Typically the event is marked handled by the class handler, and the [GotFocus](uielement_gotfocus.md) event is not raised for handling by any user code handlers on that control. Controls might handle the event in order to load a visual state that property displays a focus rectangle. A focus rectangle is an important visual component of a control for accessibility purposes, so that users can see where the current focused element is in the UI and where the user is within the tab sequence of the overall app UI. In some cases, the [FocusState](focusstate.md) of the focus action is relevant for whether a visible focus indicator should display. For more info on how class-based handling for events works, see [Events and routed events overview](http://msdn.microsoft.com/library/34c219e8-3efb-45bc-8bbd-6fd937698832). For more info on tab sequences and accessibility, see [Keyboard accessibility](http://msdn.microsoft.com/library/ddae8c4b-7907-49fe-9645-f105f8dfad8b).

## -examples

## -see-also
[LostFocus](uielement_lostfocus.md), [Control.Focus](../windows.ui.xaml.controls/control_focus.md), [Keyboard interactions](http://msdn.microsoft.com/library/ff819bac-67c0-4ec9-8921-f087be188138), [Storyboarded animations for visual states](http://msdn.microsoft.com/library/5e715281-d247-4e7f-9f88-2af0d88ed5e4)