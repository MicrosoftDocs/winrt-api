---
-api-id: M:Windows.System.User.GetUserAgeRangeAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.System.UserAgeRange> GetUserAgeRangeAsync()
-->

# Windows.System.User.GetUserAgeRangeAsync

## -description
Retrieves the age range that the current user falls into.

## -returns
An asynchronous operation that returns a [UserAgeRange](https://learn.microsoft.com/uwp/api/windows.system.useragerange) for the current user, or `null` when the age range is unknown or unavailable.

## -remarks
`UserAgeRange.Lower` and `UserAgeRange.Upper` are inclusive bounds.

| Age group | `Lower` | `Upper` |
| --- | ---: | ---: |
| Under 10 | 0 | 9 |
| 10-12 | 10 | 12 |
| 13-15 | 13 | 15 |
| 16-17 | 16 | 17 |
| 18 or older | 18 | `INT32_MAX` |

The operation returns `null` when the user's age isn't known, the feature is unavailable, or the APIs are disabled by administrative policy. A `null` result is an expected outcome and must not be treated as an exact age or as the 18-or-older range.

- Call this method on the [User](https://learn.microsoft.com/uwp/api/windows.system.user) object for the user running the current process. Use [User.GetDefault](https://learn.microsoft.com/uwp/api/windows.system.user.getdefault) to obtain that user directly.
- The app package must declare the `userAccountInformation` capability. A caller without access, or a caller using a `User` object for a different user, can receive `E_ACCESSDENIED`.
- This method returns an age bucket, not the user's exact age or date of birth.
- In C++/WinRT, call `.get()` from a suitable non-UI thread or use `co_await` from a coroutine.

### Administrative policy

Administrators can disable the Digital Safety age APIs or configure a default age group through Group Policy or MDM. When the APIs are disabled, this method returns `null`. When a default age group is configured, this method returns the `UserAgeRange` that corresponds to that group.

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
    UserAgeRange range = user.GetUserAgeRangeAsync().get();

    if (range)
    {
        int32_t lower = range.Lower();
        int32_t upper = range.Upper();

        // Use the inclusive age bucket.
    }
    else
    {
        // Use the app's fallback experience.
    }
}
```

```csharp
User user = User.GetDefault();
UserAgeRange range = await user.GetUserAgeRangeAsync();

if (range != null)
{
    int lower = range.Lower;
    int upper = range.Upper;

    // Use the inclusive age bucket.
}
else
{
    // Use the app's fallback experience.
}
```

## -see-also
[User](https://learn.microsoft.com/uwp/api/windows.system.user), [User.GetDefault](https://learn.microsoft.com/uwp/api/windows.system.user.getdefault), [User.FindAllAsync](https://learn.microsoft.com/uwp/api/windows.system.user.findallasync), [User.GetAgeVerificationStatusAsync](https://learn.microsoft.com/uwp/api/windows.system.user.getageverificationstatusasync), [UserAgeRange](https://learn.microsoft.com/uwp/api/windows.system.useragerange)

## -capabilities
userAccountInformation
