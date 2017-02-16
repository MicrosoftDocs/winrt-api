---
-api-id: P:Windows.ApplicationModel.Activation.FileActivatedEventArgs.CallerPackageFamilyName
-api-type: winrt property
---

<!-- Property syntax
public string CallerPackageFamilyName { get; }
-->

# Windows.ApplicationModel.Activation.FileActivatedEventArgs.CallerPackageFamilyName

## -description
The package family name of the app that launched your app.

## -property-value
The caller's package family name.

## -remarks
If the caller is a non-packaged app (such as a Win32 app), *CallerPackageFamilyName* will be empty, that is `""`.

## -examples

## -see-also
