---
-api-id: P:Windows.UI.Xaml.Input.GettingFocusEventArgs.CorrelationId
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public Guid CorrelationId { get; }
-->

# Windows.UI.Xaml.Input.GettingFocusEventArgs.CorrelationId

## -description

Gets the unique ID generated when a focus movement event is initiated.



## -property-value

The unique ID, if any. Otherwise, **null**.

The default is **null**.

## -remarks

Focus moves can result in a number of direct and indirect actions.

For example, there is the standard sequence of events that starts with [LosingFocus](../windows.ui.xaml/uielement_losingfocus.md) and moves through [LostFocus](../windows.ui.xaml/uielement_lostfocus.md), [GettingFocus](../windows.ui.xaml/uielement_gettingfocus.md), to [GotFocus](../windows.ui.xaml/uielement_gotfocus.md). These focus events typically get routed through multiple elements in the element tree (including the [FocusManager](focusmanager.md)).

In some cases, the focus event can also get re-routed. For example, if the target element is not valid for some reason, you might call [TrySetNewFocusedElement](losingfocuseventargs_trysetnewfocusedelement_804964491.md) from the [LosingFocus](../windows.ui.xaml/uielement_losingfocus.md) event to re-target focus to another element.

In other cases, you might need to cancel a focus change from one of your focus event handlers.

In addition, because focus events are raised asynchronously, focus might change again before a previous focus event has finished executing.

Each time a focus event is initiated, a unique CorrelationId is generated to help you track a focus event throughout these focus actions.

A new CorrelationId is generated when:

- The user moves focus.
- The app moves focus using methods such as [Control.Focus](../windows.ui.xaml.controls/control_focus_195503898.md) or [FocusManager.TryFocusAsync](focusmanager_tryfocusasync_1779533284.md).
- The app gets/loses focus due to window activation (see [CoreWindow.Activated](../windows.ui.core/corewindow_activated.md)).

## -see-also

[LosingFocusEventArgs.CorrelationId](losingfocuseventargs_correlationid.md), [Keyboard interactions](/windows/uwp/design/input/keyboard-interactions), [Focus navigation for keyboard, gamepad, remote control, and accessibility tools](/windows/uwp/design/input/focus-navigation), [Programmatic focus navigation](/windows/uwp/design/input/focus-navigation-programmatic)

## -examples
