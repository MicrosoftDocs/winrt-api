---
-api-id: T:Windows.Security.Isolation.IsolatedWindowsEnvironmentShareFileStatus
-api-type: winrt enum
---

# Windows.Security.Isolation.IsolatedWindowsEnvironmentShareFileStatus

<!--
public enum IsolatedWindowsEnvironmentShareFileStatus
-->

## -description

**Deprecated.** Enum values for the status of file share into Isolated Windows Environment.

## -enum-fields

### -field Success:0

File share into an Isolated Windows Environment succeeded.

### -field UnknownFailure:1

File share into an Isolated Windows Environment has an unknown failure.

### -field EnvironmentUnavailable:2

File share into an Isolated Windows Environment failed because the environment isn't available.

### -field AlreadySharedWithConflictingOptions: 3

File was previously shared with invalid/conflicting options. For example, if a file is launched previously with the [LaunchFileWithUIAsync](isolatedwindowsenvironment_launchfilewithuiasync_1697307470.md) call and AllowWrite in [IsolatedWindowsEnvironmentShareFileRequestOptions](isolatedwindowsenvironmentsharefilerequestoptions.md) is false, this error will be thrown.

### -field FileNotFound:4

File share into an Isolated Windows Environment failed because the file was not found.

### -field AccessDenied:5

File share into an Isolated Windows Environment failed because the user does not have access to the file.

## -remarks

> [!WARNING]
> This is a deprecated API.

## -see-also

## -examples
