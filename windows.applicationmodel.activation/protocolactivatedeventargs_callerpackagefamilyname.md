---
-api-id: P:Windows.ApplicationModel.Activation.ProtocolActivatedEventArgs.CallerPackageFamilyName
-api-type: winrt property
---

<!-- Property syntax
public string CallerPackageFamilyName { get; }
-->

# Windows.ApplicationModel.Activation.ProtocolActivatedEventArgs.CallerPackageFamilyName

## -description
Gets the package family name of the application that activated the current application.

## -property-value
The package family name of the application that activated the current application.

## -remarks
If the caller is a non-packaged app (such as a Win32 app), *CallerPackageFamilyName* will be empty, that is `""`.

## -examples

## -see-also
