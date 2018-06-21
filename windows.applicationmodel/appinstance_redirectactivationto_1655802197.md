---
-api-id: M:Windows.ApplicationModel.AppInstance.RedirectActivationTo
-api-type: winrt method
---

<!-- Method syntax.
public void AppInstance.RedirectActivationTo()
-->

# Windows.ApplicationModel.AppInstance.RedirectActivationTo

## -description
Redirects activation of the current app instance to the specified instance. 

## -remarks
Redirection is a terminal operation.
After redirecting, the app can call only [CoreApplication.Exit](../windows.applicationmodel.core/coreapplication_exit_1158854104.md). 
After the redirection, the app is closed. 

An app indicates whether it supports multiple instances in its manifest.
The splash screen is not shown until the app decides whether to redirect during main. 
If the app fails to decide within a time-out period, it is closed.

There is a potential race condition if an app identifies an instance for redirection, but that instance dies before it can be activated. 
In this case, this activation fails. 

## -see-also
[CoreApplication.Exit](../windows.applicationmodel.core/coreapplication_exit_1158854104.md)

## -examples
This example redirects activation to the instance recommended by the shell.
The example first checks whether there is a recommended instance and whether it is suitable. 
If the shell does not have preference, the app can look for an existing app instance to redirect to or attempt to register itself as the target.

```csharp
AppInstance RecommendedInstance = AppInstance.RecommendedInstance;
if ((RecommendedInstance != null) && SelectedKeyIncludesMyKey(RecommendedInstance.Key))
{
    RecommendedInstance.RedirectActivationTo();
}
else
{
    // Look for existing instance or attempt to register itself as target.
}
```
