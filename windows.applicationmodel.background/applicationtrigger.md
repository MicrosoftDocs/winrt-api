---
-api-id: T:Windows.ApplicationModel.Background.ApplicationTrigger
-api-type: winrt class
---

<!-- Class syntax.
public class ApplicationTrigger : Windows.ApplicationModel.Background.IApplicationTrigger, Windows.ApplicationModel.Background.IBackgroundTrigger
-->

# Windows.ApplicationModel.Background.ApplicationTrigger

## -description

This is used by the [BackgroundTaskBuilder](backgroundtaskbuilder.md) to programmatically trigger a background task from within your application.

## -remarks

Use the [SetTrigger](backgroundtaskbuilder_settrigger_2125876510.md) method to specify the [IBackgroundTrigger](ibackgroundtrigger.md) for the background task. See [Trigger a background task from within your app](/windows/uwp/launch-resume/trigger-background-task-from-app) for an example of how to use this class to activate a background task from within your app.

> [!IMPORTANT]
> An app can only register one **ApplicationTrigger** with the [BackgroundTaskBuilder](/uwp/api/Windows.ApplicationModel.Background.BackgroundTaskBuilder) at any given time.

## -examples

## -see-also

[Trigger a background task from within your app](/windows/uwp/launch-resume/trigger-background-task-from-app), [IBackgroundTrigger](ibackgroundtrigger.md)
