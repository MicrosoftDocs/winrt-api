---
-api-id: P:Windows.UI.Xaml.Controls.SearchBox.FocusOnKeyboardInputProperty
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.DependencyProperty FocusOnKeyboardInputProperty { get; }
-->

# Windows.UI.Xaml.Controls.SearchBox.FocusOnKeyboardInputProperty

## -description
Identifies the [FocusOnKeyboardInput](searchbox_focusonkeyboardinput.md) dependency property.

## -property-value
The identifier for the [FocusOnKeyboardInput](searchbox_focusonkeyboardinput.md) dependency property.

## -remarks
> [!NOTE]
> When FocusOnKeyboardInput is set to true, there’s an issue that sometimes causes users to see duplicate characters in the SearchBox control when using the touch keyboard. You can work around the issue by following these steps: 1. Register for the PrepareForFocusOnKeyboardInput event and use the event handler to set FocusOnKeyboardInput to false. 2. Register for the LostFocus event and use the event handler to set FocusOnKeyboardInput back to true.

## -examples

## -see-also
