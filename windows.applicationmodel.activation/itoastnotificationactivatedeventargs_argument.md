---
-api-id: P:Windows.ApplicationModel.Activation.IToastNotificationActivatedEventArgs.Argument
-api-type: winrt property
---

<!-- Property syntax
public string Argument { get; }
-->

# Windows.ApplicationModel.Activation.IToastNotificationActivatedEventArgs.Argument

## -description
Gets the arguments that the app can retrieve after it is activated through an interactive toast notification.

## -property-value
The arguments that the app can retrieve after it is activated through an interactive toast notification. The value of this property is defined previously in the XML that describes the data to deliver for the toast notification. The following elements and attributes of that XML define the value:


+ The **arguments** attribute of the  element, if the user performs an action inside the interactive toast notification.
+ The **launch** attribute of the  element, if the user simply clicks the body of the toast notification.


## -remarks

## -examples

## -see-also
[ToastNotificationActivatedEventArgs.Argument](toastnotificationactivatedeventargs_argument.md)