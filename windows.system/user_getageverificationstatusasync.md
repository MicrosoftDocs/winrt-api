---
-api-id: M:Windows.System.User.GetAgeVerificationStatusAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.System.UserAgeVerificationStatus> GetAgeVerificationStatusAsync()
-->

# Windows.System.User.GetAgeVerificationStatusAsync

## -description
Retrieves a value indicating whether and how the current user's age has been verified.

## -returns
An asynchronous operation that returns a [UserAgeVerificationStatus](https://learn.microsoft.com/uwp/api/windows.system.userageverificationstatus) value for the current user.

## -remarks
The following table describes the possible return values.

| Value | Name | Meaning |
| ---: | --- | --- |
| 0 | `NotApplicable` | Age verification doesn't apply, no verification signal is available, or the feature is unavailable or disabled. |
| 1 | `TemporarilyUnavailable` | The verification status can't currently be determined. The app can retry later. |
| 2 | `Unverified` | The user's age hasn't been verified. |
| 3 | `OptedOut` | The user has opted out of age verification. |
| 4 | `Verified` | The user's age has been verified. |

`NotApplicable` and `TemporarilyUnavailable` don't establish that the user is either verified or unverified. Handle them as separate states.

- Call this method on the [User](https://learn.microsoft.com/uwp/api/windows.system.user) object for the user running the current process. Use [User.GetDefault](https://learn.microsoft.com/uwp/api/windows.system.user.getdefault) to obtain that user directly.
- The app package must declare the `userAccountInformation` capability. A caller without access, or a caller using a `User` object for a different user, can receive `E_ACCESSDENIED`.
- In C++/WinRT, call `.get()` from a suitable non-UI thread or use `co_await` from a coroutine.

### Administrative policy

Administrators can disable the Digital Safety age APIs or configure a default verification status through Group Policy or MDM. When the APIs are disabled, this method returns `NotApplicable`. When a default status is configured, this method returns the configured `Verified` or `Unverified` value.

## -examples
```cppwinrt
#include <winrt/Windows.Foundation.h>
#include <winrt/Windows.System.h>

using namespace winrt;
using namespace winrt::Windows::System;

int wmain()
{
    init_apartment();

    User user = User::GetDefault();
    UserAgeVerificationStatus status =
        user.GetAgeVerificationStatusAsync().get();

    switch (status)
    {
    case UserAgeVerificationStatus::Verified:
        // The user's age is verified.
        break;
    case UserAgeVerificationStatus::Unverified:
        // The user's age isn't verified.
        break;
    case UserAgeVerificationStatus::OptedOut:
        // The user opted out.
        break;
    case UserAgeVerificationStatus::TemporarilyUnavailable:
        // Retry later or use the app's fallback experience.
        break;
    case UserAgeVerificationStatus::NotApplicable:
        // Use the app's fallback experience.
        break;
    }
}
```

```csharp
User user = User.GetDefault();
UserAgeVerificationStatus status =
    await user.GetAgeVerificationStatusAsync();

switch (status)
{
    case UserAgeVerificationStatus.Verified:
        break;
    case UserAgeVerificationStatus.Unverified:
        break;
    case UserAgeVerificationStatus.OptedOut:
        break;
    case UserAgeVerificationStatus.TemporarilyUnavailable:
        break;
    case UserAgeVerificationStatus.NotApplicable:
        break;
}
```

## -see-also
[User](https://learn.microsoft.com/uwp/api/windows.system.user), [User.GetDefault](https://learn.microsoft.com/uwp/api/windows.system.user.getdefault), [User.FindAllAsync](https://learn.microsoft.com/uwp/api/windows.system.user.findallasync), [User.GetUserAgeRangeAsync](https://learn.microsoft.com/uwp/api/windows.system.user.getuseragerangeasync), [UserAgeVerificationStatus](https://learn.microsoft.com/uwp/api/windows.system.userageverificationstatus)

## -capabilities
userAccountInformation
