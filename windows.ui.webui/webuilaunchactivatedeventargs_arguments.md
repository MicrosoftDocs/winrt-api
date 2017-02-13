---
-api-id: P:Windows.UI.WebUI.WebUILaunchActivatedEventArgs.Arguments
-api-type: winrt property
---

<!-- Property syntax
public string Arguments { get; }
-->

# Windows.UI.WebUI.WebUILaunchActivatedEventArgs.Arguments

## -description
Gets the arguments that are passed to the app during its launch activation.

## -property-value
The list of arguments.

## -remarks
These arguments provide additional context for this activation. Similar to command-line arguments, this string can be parsed by an app to determine what action it should take in response to this activation.

> [!NOTE]
> An app should always regard the arguments string as untrusted data and must parse and validate the string carefully before taking action based on its contents. Blindly using the arguments string without examining it first can present a security risk.

## -examples

## -see-also
