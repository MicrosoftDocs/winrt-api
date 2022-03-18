---
-api-id: P:Windows.System.Profile.SharedModeSettings.IsEnabled
-api-type: winrt property
---

<!-- Property syntax
public bool IsEnabled { get; }
-->

# Windows.System.Profile.SharedModeSettings.IsEnabled

## -description
Gets a Boolean value that indicates if shared mode is currently enabled.

## -property-value
A Boolean value that indicates if shared mode is currently enabled.

## -remarks
Returns **true** when the [EnableSharedPCMode](/windows/client-management/mdm/sharedpc-csp) policy is set.  

Returns **true** when running on a Surface Hub.  

Examples of changes you might make in an education environment:  
 - Not launch the first-run experience

A **true** value means the PC is running in scenarios where multiple consecutive users use the PC. These user accounts may be deleted, which means that users may have a new account created each time they use the same device.

## -examples
```csharp
if (!Windows.System.Profile.SharedModeSettings.IsEnabled)
{
    LaunchWelcomeExperience();
}
```

## -see-also
