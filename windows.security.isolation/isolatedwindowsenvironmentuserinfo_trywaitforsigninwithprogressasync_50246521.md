---
-api-id: M:Windows.Security.Isolation.IsolatedWindowsEnvironmentUserInfo.TryWaitForSignInWithProgressAsync
-api-type: winrt method
---

# Windows.Security.Isolation.IsolatedWindowsEnvironmentUserInfo.TryWaitForSignInWithProgressAsync

<!--
public Windows.Foundation.IAsyncOperationWithProgress<bool,Windows.Security.Isolation.IsolatedWindowsEnvironmentSignInProgress> TryWaitForSignInWithProgressAsync ();
-->

## -description

**Deprecated.** An asynchronous function which allows callers to wait for the environment sign-in process to complete before continuing. This function provides progress updates as it waits for sign-in; [TryWaitForSignInAsync](isolatedwindowsenvironmentuserinfo_trywaitforsigninasync_2135355077.md) does not.

## -returns

An asynchronous operation which returns a boolean value indicating whether sign-in was successful, and a progress value indicating the current progress of the sign-in operation.

## -remarks

> [!WARNING]
> This is a deprecated API.

## -see-also

[TryWaitForSignInAsync](isolatedwindowsenvironmentuserinfo_trywaitforsigninasync_2135355077.md), [IsolatedWindowsEnvironmentSignInProgress](isolatedwindowsenvironmentsigninprogress.md)

## -examples

The following example gets an isolated environment by its Id and attempts to sign in using `TryWaitForSignInWithProgressAsync` while checking the progress of the sign in operation.

``` cpp
void GetEnvironmentSignInInfo()
{
    auto environment = IsolatedWindowsEnvironment::GetById(environmentId);
    
    if (!environment)
    {
        LogMessage(L"Environment does not exist.");
        return;
    }
    
    auto result = environment.GetUserInfo();
    
    if (!result)
    {
        LogMessage(L"Failed to initialize GetUserInfo – verify that the environment exists.");
        return;
    }
    
    auto operation = result.TryWaitForSignInWithProgressAsync();
    
    operation.Progress([&](auto const&, IsolatedWindowsEnvironmentSignInProgress progress)
    {
        switch (progress)
        {
            case IsolatedWindowsEnvironmentSignInProgress::Connecting:
                UpdateProgressDialogUI(L"Connecting to isolated environment.");
                break;
            case IsolatedWindowsEnvironmentSignInProgress::Connected:
                UpdateProgressDialogUI(L"Established connection to isolated environment.");
                break;
            case IsolatedWindowsEnvironmentSignInProgress::Authenticating:
                UpdateProgressDialogUI(L"Signing in to isolated environment.");
                break;
            case IsolatedWindowsEnvironmentSignInProgress::SettingUpAccount:
                UpdateProgressDialogUI(L"Setting up user session.");
                break;
            case IsolatedWindowsEnvironmentSignInProgress::Finalizing:
                UpdateProgressDialogUI(L"Configuring user session settings.");
                break;
            case IsolatedWindowsEnvironmentSignInProgress::Completed:
                UpdateProgressDialogUI(L"Sign-in is complete.");
                break;
            default:
                LogMessage(L"Encountered an unknown progress state, this is unexpected. Do not update UI dialog.\n");
        }
    });
}
```
