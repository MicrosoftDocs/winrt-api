---
-api-id: E:Windows.UI.Xaml.UIElement.LostFocus
-api-type: winrt event
---

<!-- Event syntax
public event Windows.UI.Xaml.RoutedEventHandler LostFocus
-->

# Windows.UI.Xaml.UIElement.LostFocus

## -description

Occurs when a [UIElement](uielement.md) loses focus. This event is raised asynchronously, so focus can move again before bubbling is complete.

## -xaml-syntax

```xaml
<uiElement LostFocus="eventhandler"/>
```

## -remarks

We recommend using the [UIElement](../windows.ui.xaml/uielement.md) focus routed events instead of [FocusManager](focusmanager.md) events whenever possible.

Only a single UI element at a time can have focus.

A control can lose focus when another control gets focus, the application view changes, the user switches applications, or the user interacts with the system such that the application is no longer in the foreground.

[LostFocus](uielement_lostfocus.md) is raised before [GotFocus](uielement_gotfocus.md).

Keyboard focus is particularly relevant for keyboard event handling, because only the currently keyboard-focused [UIElement](uielement.md) can be the source of the [KeyUp](uielement_keyup.md) and [KeyDown](uielement_keydown.md) key events. Applications might call [Focus](../windows.ui.xaml.controls/control_focus_195503898.md) as an initialization action so that the key events in the app as a whole can be used to detect access or accelerator keys. For more info, see [Keyboard interactions](http://msdn.microsoft.com/library/ff819bac-67c0-4ec9-8921-f087be188138).

[LostFocus](uielement_lostfocus.md) is a routed event. For more info on how class-based handling for events works, see [Events and routed events overview](http://msdn.microsoft.com/library/34c219e8-3efb-45bc-8bbd-6fd937698832).

Specific Windows Runtime controls may have class-based handling for the [LostFocus](uielement_lostfocus.md) event. If so, the control probably has an override for the method [OnLostFocus](../windows.ui.xaml.controls/control_onlostfocus_679101471.md). Typically the event is marked handled by the class handler, and the [LostFocus](uielement_lostfocus.md) event is not raised for handling by any user code handlers on that control. Controls might handle the event in order to unload a visual state that displayed a focus rectangle in response to [OnGotFocus](../windows.ui.xaml.controls/control_ongotfocus_1398920478.md).

A control's focus rectangle is an important visual component that aids accessibility by identifying the current focused element and indicating where the user is within the tab sequence of the application UI. In some cases, the [FocusState](focusstate.md) of the focus action is relevant for whether a visible focus indicator should display.

For more info on tab sequences and accessibility, see [Keyboard accessibility](http://msdn.microsoft.com/library/ddae8c4b-7907-49fe-9645-f105f8dfad8b).

## -examples

## -see-also

[RoutedEventArgs](routedeventargs.md), [LosingFocus](uielement_losingfocus.md), [LosingFocusEvent](uielement_losingfocusevent.md), [GotFocus](uielement_gotfocus.md), [GettingFocusEvent](uielement_gettingfocusevent.md), [GettingFocus](uielement_gettingfocus.md), [Control.Focus](../windows.ui.xaml.controls/control_focus_195503898.md), [AddHandler](uielement_addhandler_2121467075.md), [Events and routed events overview](http://msdn.microsoft.com/library/34c219e8-3efb-45bc-8bbd-6fd937698832), [Keyboard interactions](https://docs.microsoft.com/windows/uwp/design/input/keyboard-interactions), [Focus navigation for keyboard, gamepad, remote control, and accessibility tools](https://docs.microsoft.com/windows/uwp/design/input/focus-navigation), [Programmatic focus navigation](https://docs.microsoft.com/windows/uwp/design/input/focus-navigation-programmatic)