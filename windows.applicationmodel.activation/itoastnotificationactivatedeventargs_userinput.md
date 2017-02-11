---
-api-id: P:Windows.ApplicationModel.Activation.IToastNotificationActivatedEventArgs.UserInput
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.ValueSet UserInput { get; }
-->

# Windows.ApplicationModel.Activation.IToastNotificationActivatedEventArgs.UserInput

## -description
Gets a set of values that you can use to obtain the user input from an interactive toast notification.

## -property-value
A set of values that you can use to obtain the user input from an interactive toast notification.

This information consists of pairs of keys and values, in which the keys are the identifiers for the  elements for which the user provided input and the values represent the input from the user. For  elements that specify that the type of the input is text, the value is the string that the user specified. For  elements that specify that the type of the input is an item that the user selects from a predefined list, the value is the identifier for the item that the user selected.

## -remarks

## -examples

## -see-also
[ValueSet](../windows.foundation.collections/valueset.md), [ToastNotificationActivatedEventArgs.UserInput](toastnotificationactivatedeventargs_userinput.md)