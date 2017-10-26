---
-api-id: P:Windows.ApplicationModel.Activation.LaunchActivatedEventArgs.PrelaunchActivated
-api-type: winrt property
---

<!-- Property syntax
public bool PrelaunchActivated { get; }
-->

# Windows.ApplicationModel.Activation.LaunchActivatedEventArgs.PrelaunchActivated

## -description
Indicates whether the app was pre-launched.

## -property-value
Indicates whether the app was pre-launched. **TRUE** indicates it was; otherwise, **FALSE**.

## -remarks
When available system resources allow, the startup performance of UWP app is improved by proactively launching the user’s most frequently used apps in the background. See [Handle app prelaunch](http://msdn.microsoft.com/library/a4838ac2-22d7-46ba-9eb2-f3c248e22f52) for details.

## -examples

## -see-also
[Handle app prelaunch](http://msdn.microsoft.com/library/a4838ac2-22d7-46ba-9eb2-f3c248e22f52)