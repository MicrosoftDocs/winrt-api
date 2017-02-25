---
-api-id: M:Windows.UI.Xaml.Controls.ToggleSwitch.OnToggled
-api-type: winrt method
---

<!-- Method syntax
virtual protected void OnToggled()
-->

# Windows.UI.Xaml.Controls.ToggleSwitch.OnToggled

## -description
Invoked before the [Toggled](toggleswitch_toggled.md) event is raised.

## -remarks
Override this method to provide a class-based behavior that should be invoked each time that the [Toggled](toggleswitch_toggled.md) event is raised. The event data does not contain the state information, but you can determine the state from [IsOn](toggleswitch_ison.md), which represents the new value.

<!--Rolling the dice on this one because cannot see implementation. Would guess is class handler and not oldskool CLR event On*, despite lack of eventargs in signature.-->

## -examples

## -see-also
