---
-api-id: T:Windows.ApplicationModel.Background.BackgroundTaskRegistrationGroup
-api-type: winrt class
---

<!-- Class syntax.
public class BackgroundTaskRegistrationGroup
-->

# Windows.ApplicationModel.Background.BackgroundTaskRegistrationGroup

## -description
Provides grouping semantics so that background task registration can be maintained separately.

## -remarks
Developers are encouraged to unregister, and then register, all background tasks used by the application when the app launches. However, in addition to unregistering the app's background tasks, this can also unregister background tasks registered by frameworks used by the app.

Grouped background task registration provides roughly the equivalent of a namespace for background tasks. You can register/unregister background tasks that belong to a group that you define without disturbing the registration of other background tasks on the device.

## -examples
[Background activation sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/BackgroundActivation)  
[Background task sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/BackgroundTask) See scenario 6 for a grouped task example.

## -see-also
[Group background task registration](/windows/uwp/launch-resume/group-background-tasks)  
[Launching, resuming, and background tasks](/windows/uwp/launch-resume/index)  
