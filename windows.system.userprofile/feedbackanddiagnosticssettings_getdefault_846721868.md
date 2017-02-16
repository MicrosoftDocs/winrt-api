---
-api-id: M:Windows.System.UserProfile.FeedbackAndDiagnosticsSettings.GetDefault
-api-type: winrt method
---

<!-- Method syntax.
public FeedbackAndDiagnosticsSettings FeedbackAndDiagnosticsSettings.GetDefault()
-->

# Windows.System.UserProfile.FeedbackAndDiagnosticsSettings.GetDefault

## -description
Retrieves the default feedback and diagnostics settings. 

## -returns
A settings object that contains the user's current feedback and diagnostics settings.

## -remarks

## -see-also

## -examples

```csharp
// From within a single user environment.
Windows.System.UserProfile.FeedbackAndDiagnosticsSettings defaultUser = 
    Windows.System.UserProfile.FeedbackAndDiagnosticsSettings.GetDefault(); 

Log.Comment("Current user tailored experiences enabled: " +  
    defaultUser.IsAccessToDiagnosticDataForTailoringExperiencesEnabled);
```