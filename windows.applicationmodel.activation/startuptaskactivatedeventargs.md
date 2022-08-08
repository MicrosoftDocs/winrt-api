---
-api-id: T:Windows.ApplicationModel.Activation.StartupTaskActivatedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class StartupTaskActivatedEventArgs : IActivatedEventArgs, IActivatedEventArgsWithUser
-->

# Windows.ApplicationModel.Activation.StartupTaskActivatedEventArgs

## -description
Provides information when an app is activated at device startup or user login.

## -remarks
This functionality is only supported on Windows Desktop.

## -see-also
[Windows.ApplicationModel.Activation.IStartupTaskActivatedEventArgs](../windows.applicationmodel.activation/istartuptaskactivatedeventargs.md),
[Windows.ApplicationModel.StartupTask](/uwp/api/windows.applicationmodel.startuptask)

## -examples
```csharp
protected override void OnActivated(IActivatedEventArgs args)
{
    string argString = string.Empty;

    // Existing behavior to differentiate different activation kinds,
    // and to extract any argument payload.
    switch (args.Kind)
    {
        case ActivationKind.StartupTask:
            var startupArgs = args as StartupTaskActivatedEventArgs;
            string taskId = startupArgs.TaskId;
            break;
    }
}
```
