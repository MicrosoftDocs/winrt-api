---
-api-id: M:Windows.Security.Isolation.IsolatedWindowsEnvironment.GetUserInfo
-api-type: winrt method
---

# Windows.Security.Isolation.IsolatedWindowsEnvironment.GetUserInfo

<!--
public Windows.Security.Isolation.IsolatedWindowsEnvironmentUserInfo GetUserInfo ();
-->

## -description

**Deprecated.** Since the isolated environment user is different and separate from the host user, a host application may need to know information about the user signed into the isolated environment, such as the username and SID. This API exposes those values without needing to wait for the sign-in process to complete.

## -returns

IsolatedWindowsEnvironmentUserInfo

## -remarks

> [!WARNING]
> This is a deprecated API.

## -see-also

## -examples
