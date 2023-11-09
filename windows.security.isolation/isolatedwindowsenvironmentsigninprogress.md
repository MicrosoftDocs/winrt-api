---
-api-id: T:Windows.Security.Isolation.IsolatedWindowsEnvironmentSignInProgress
-api-type: winrt enum
---

# Windows.Security.Isolation.IsolatedWindowsEnvironmentSignInProgress

<!--
public enum IsolatedWindowsEnvironmentSignInProgress
-->

## -description

**Deprecated.** Specifies the progress of a sign-in operation.

## -enum-fields

### -field Connecting: 0

Connecting to the Isolated Windows Environment.

### -field Connected: 1

Established connection to the Isolated Windows Environment.

### -field Authenticating: 2

Signing in to the Isolated Windows Environment.

### -field SettingUpAccount: 3

Setting up user session in the Isolated Windows Environment.

### -field Finalizing: 4

Configuring user session settings in the Isolated Windows Environment.

### -field Completed: 5

Sign-in to the Isolated Windows Environment is complete.

## -remarks

> [!WARNING]
> This is a deprecated API.

The progress state values are expected to arrive in order (`Connecting` -> `Connected` -> `Authenticating` -> `SettingUpAccount` -> `Finalizing` -> `Completed`), but may skip states if [TryWaitForSignInWithProgressAsync](isolatedwindowsenvironmentuserinfo_trywaitforsigninwithprogressasync_50246521.md) is called while sign-in is already underway.

## -see-also

## -examples
