---
-api-id: M:Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorInfo.UpdateDevicePresenceAsync(Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorDevicePresence)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncAction SecondaryAuthenticationFactorInfo.UpdateDevicePresenceAsync(SecondaryAuthenticationFactorDevicePresence presenceState)
-->

# Windows.Security.Authentication.Identity.Provider.SecondaryAuthenticationFactorInfo.UpdateDevicePresenceAsync

## -description
Manually assigns a presence state to a device.

## -parameters

### -param presenceState
A [**SecondaryAuthenticationFactorDevicePresence**](SecondaryAuthenticationFactorDevicePresence.md) value indicating the device's presence state.

## -returns
An asynchronous action for the operation.

## -remarks
This method should only be used when a companion device's monitoring mode is set to [**SecondaryAuthenticationFactorDevicePresenceMonitoringMode.AppManaged**](SecondaryAuthenticationFactorDevicePresenceMonitoringMode.md). In this case, the app that is using the companion device for authentication must incorporate the third party app's presence-monitoring functionality and manually assign a [**SecondaryAuthenticationFactorDevicePresence**](SecondaryAuthenticationFactorDevicePresence.md) value according to the result. 

This should be done in a background task like so:

```csharp
using System;
using Windows.Security.Authentication.Identity.Provider;
using Windows.Storage.Streams;
using Windows.Security.Cryptography;
using System.Threading;
using Windows.ApplicationModel.Background;

namespace SecondaryAuthFactorSample {

public sealed class DevicePresenceMonitoringTask : IBackgroundTask {
    private static IBackgroundTaskInstance _taskInstance;
    private BackgroundTaskDeferral _deferral;
    private void PresenceMonitor() {
        // Query the devices which can do presence check for the console user
        IReadOnlyList<SecondaryAuthenticationFactorInfo> deviceInfoList =
        await SecondaryAuthenticationFactorRegistration.FindAllRegisteredDeviceInfoAsync(SecondaryAuthenticaitonFactorDeviceFindScope.CurrentUser);
        if (deviceInfoList.Count == 0) {
            return;
        }
        foreach (SecondaryAuthenticationFactorInfo deviceInfo in deviceInfoList){
            if (deviceInfo.PresenceMonitoringMode != SecondaryAuthenticationFactorDevicePresenceMonitoringMode.SelfManaged){
                // Skip the device which doesn't need to be monitored in the background task
                continue;
            }
            SecondaryAuthenticationFactorDevicePresenceState state = SecondaryAuthenticationFactorDevicePresenceState.Absent;
            //
            // 3rd party device specific code
            //
            // The background task should check if the device is near-by or not and update the state value
            // if (device is nearby){
                // state = SecondaryAuthenticationFactorDevicePresenceState.Present;
            // }
            await deviceInfo.UpdateDevicePresenceStateAsync(state);
        }
    }
    public async void OnAuthenticationStageChanged(object sender, SecondaryAuthenticationFactorAuthenticationStageChangedEventArgs args){
        Debug.WriteLine("Authentication Stage = " + args.StageInfo.AuthenticationStage.ToString());
        if (args.StageInfo.Stage == SecondaryAuthenticationFactorAuthenticationStage.CheckingDevicePresence){
            PresenceMonitor();
            _deferral.Complete();
            break;
        }
    }
    //
    // The Run method is the entry point of a background task.
    //
    
    public async void Run(IBackgroundTaskInstance taskInstance){
        _taskInstance = taskInstance;
        _deferral = taskInstance.GetDeferral();
        // Register canceled event for this task
        taskInstance.Canceled += TaskInstanceCanceled;
        // Register AuthenticationStageChanged event
        SecondaryAuthenticationFactorRegistration.AuthenticationStageChanged += OnAuthenticationStageChanged;
    }
    
    void TaskInstanceCanceled(IBackgroundTaskInstance sender, BackgroundTaskCancellationReason reason){
        _deferral.Complete();
    }
}

}
```

## -see-also

## -examples

