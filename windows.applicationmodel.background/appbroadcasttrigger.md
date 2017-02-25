---
-api-id: T:Windows.ApplicationModel.Background.AppBroadcastTrigger
-api-type: winrt class
---

<!-- Class syntax.
public class AppBroadcastTrigger : IBackgroundTrigger
-->

# Windows.ApplicationModel.Background.AppBroadcastTrigger

## -description
Represents an event that triggers a background task to run when an application starts gameplay broadcasting.

## -remarks
> [!IMPORTANT]
> Only first-party applications should use this class.  

The background task must be declared in the manifest before the registration can be successful.
An instance of this class is passed to the background task in its [Run](ibackgroundtask_run.md) method.
