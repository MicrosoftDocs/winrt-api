---
-api-id: P:Windows.ApplicationModel.Activation.LaunchActivatedEventArgs.Arguments
-api-type: winrt property
---

<!-- Property syntax
public string Arguments { get; }
-->

# Windows.ApplicationModel.Activation.LaunchActivatedEventArgs.Arguments

## -description
Gets the arguments that are passed to the app during its launch activation.

## -property-value
The list of arguments. This value can be used to control the behavior of the app when it is launched through a secondary tile or through a toast.

## -remarks
These arguments provide additional context for this activation. Similar to command-line arguments, this string can be parsed by an app to determine what action it should take in response to this activation. This argument string comes from a property such as [SecondaryTile.Arguments](../windows.ui.startscreen/secondarytile_arguments.md) or a toast's XML payload, through the *launch* attribute of the [toast](/uwp/schemas/tiles/toastschema/element-toast) element or the *arguments* attribute of the [command](/uwp/schemas/tiles/toastschema/element-command) element.



> [!NOTE]
> An app should always regard the arguments string as untrusted data and must parse and validate the string carefully before taking action based on its contents. Blindly using the arguments string without examining it first can present a security risk.

## -examples

## -see-also
