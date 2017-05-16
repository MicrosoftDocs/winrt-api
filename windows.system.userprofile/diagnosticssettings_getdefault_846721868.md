---
-api-id: M:Windows.System.UserProfile.DiagnosticsSettings.GetDefault
-api-type: winrt method
---

<!-- Method syntax.
public DiagnosticsSettings DiagnosticsSettings.GetDefault()
-->

# Windows.System.UserProfile.DiagnosticsSettings.GetDefault

## -description

Retrieves the default diagnostics settings.

## -returns

A settings object that contains the user's current diagnostics settings.

## -remarks

## -see-also

## -examples

```csharp
// From within a single user environment.
Windows.System.UserProfile.DiagnosticsSettings defaultUser =
    Windows.System.UserProfile.DiagnosticsSettings.GetDefault();

System.Diagnostics.Debug.WriteLine("Current user tailored experiences enabled: " +
    defaultUser.CanUseDiagnosticsToTailorExperiences.ToString());
```

