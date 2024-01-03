---
-api-id: P:Windows.UI.Xaml.Controls.Control.FocusState
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.FocusState FocusState { get; }
-->

# Windows.UI.Xaml.Controls.Control.FocusState

## -description
Gets a value that specifies whether this control has focus, and the mode by which focus was obtained.

## -property-value
A value of the enumeration. A value of **Unfocused** indicates that the control does not have focus.

## -remarks
This property supports controls that use different visual styles depending on whether the control was focused by the keyboard or by other means. Some controls use visual states that show a visible focus indicator if the control was focused by a keyboard action, but do not show the indicator if the control was focused by a pointer action. The internal logic of such a control implements [OnGotFocus](control_ongotfocus_1398920478.md) and then gets the value of FocusState from the sender. If FocusState is [Keyboard](../windows.ui.xaml/focusstate.md), then a different named visual state that includes a focus rectangle is loaded, by calling [GoToState](../windows.ui.xaml/visualstatemanager_gotostate_443481648.md). Typically, focus-related visual states are grouped together in the default control template XAML. Custom controls that want to use different focus visuals depending on the means of focus can implement this same logic themselves. See [OnGotFocus](control_ongotfocus_1398920478.md).

Another way to use this property is to use [FocusManager](../windows.ui.xaml.input/focusmanager.md) to determine which element in the overall UI has focus, and then call FocusState on that element to get information on how that control received focus.

### Notes for previous versions

> [!NOTE]
> In Windows 8, when FocusState is [Programmatic](../windows.ui.xaml/focusstate.md), the keyboard focus visual is shown even if the prior method of input was pointer. In Windows 8.1, when you call [Focus](control_focus_195503898.md) (*FocusState.Programmatic*), the prior FocusState, either [Pointer](../windows.ui.xaml/focusstate.md) or [Keyboard](../windows.ui.xaml/focusstate.md), is retained so that the correct focus visual is shown. This means that if you check the value of the FocusState property after you call [Focus](control_focus_195503898.md) (*FocusState.Programmatic*), the FocusState property will have a value of either [Pointer](../windows.ui.xaml/focusstate.md) or [Keyboard](../windows.ui.xaml/focusstate.md).

In an app that’s compiled for Windows 8, but run in Windows 8.1, the Windows 8 behavior is retained. The FocusState property value is [Programmatic](../windows.ui.xaml/focusstate.md) and the keyboard focus visual is shown.

> [!NOTE]
> Classes that inherit from [ItemsControl](itemscontrol.md), such as [ListBox](listbox.md) and [AutoSuggestBox](autosuggestbox.md), do not propagate the FocusState property. They will always return **Unfocused**. Access the correct value through **RoutedEventArgs.OriginalSource**.

## -examples

## -see-also
