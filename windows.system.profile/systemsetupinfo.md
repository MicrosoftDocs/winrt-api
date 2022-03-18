---
-api-id: T:Windows.System.Profile.SystemSetupInfo
-api-type: winrt class
ms.custom: RS5
---

<!-- Class syntax.
public class SystemSetupInfo 
-->

# Windows.System.Profile.SystemSetupInfo

## -description
Provides a property and an event that describe the current stage in the lifecycle of the Out-of-Box Experience (OOBE).

## -remarks
The Out-of-Box Experience (OOBE) is the flow that occurs the first time the user turns on a Windows 10 device. The OOBE obtains acceptance of the EULA, sets the system default locale, and helps set up the initial user account.

## -see-also

## -examples
A Universal Windows Platform (UWP) app needs to know whether OOBE is complete, since it has special behavior during OOBE (for example, a scoped feature set in the user interface (UI), or background tasks that only start after OOBE is complete). As an OEM, this could be your app that runs during OOBE.

```csharp
private bool ShouldUseSimpleUserInterface()
{
    var oobeState = Windows.System.Profile.SystemSetupInfo.OutOfBoxExperienceState;

    // When this UWP is shown before OOBE is complete, use a simplified UI
    // with limited options, which matches the style of the rest of OOBE.
    return (oobeState != SystemOutOfBoxExperienceState.Completed);
}
```

As an OEM, you want to know that a device successfully boots to OOBE during factory-floor testing. You want every device to go through this testing as a final verification step in your manufacturing process, and therefore during your automation you want to be notified when OOBE is in progress and ready.

```csharp
// Task that has its result set once OOBE is in progress.
private TaskCompletionSource<object> oobeInProgress;

// Called when OOBE state changes. Guaranteed to be called at least once, at
// the time of event registration.
private void OnOobeStateChanged(object sender, object e)
{
    var oobeState = Windows.System.Profile.SystemSetupInfo.OutOfBoxExperienceState;
    if (oobeState == SystemOutOfBoxExperienceState.InProgress)
    {
        oobeInProgress.TrySetResult(null);
    } 
}

private async void WaitForOobeStartedAsync()
{
    oobeInProgress = new TaskCompletionSource<object>();
    Windows.System.Profile.SystemSetupInfo.OutOfBoxExperienceStateChanged += OnOobeStateChanged;
    await oobeInProgress.Task; // NOTE: you could add a timeout here, and fail when hit.
    Windows.System.Profile.SystemSetupInfo.OutOfBoxExperienceStateChanged -= OnOobeStateChanged;
 }
```
