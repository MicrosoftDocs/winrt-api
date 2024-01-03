---
-api-id: T:Windows.Security.Isolation.IsolatedWindowsEnvironmentLaunchFileStatus
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum IsolatedWindowsEnvironmentLaunchFileStatus : int 
-->

# Windows.Security.Isolation.IsolatedWindowsEnvironmentLaunchFileStatus

## -description

**Deprecated.** Enum values for the status of file launch into Isolated Windows Environment.

## -enum-fields

### -field Success:0

File launch into an Isolated Windows Environment succeeded.

### -field UnknownFailure:1

File launch into an Isolated Windows Environment has an unknown failure.

### -field EnvironmentUnavailable:2

File launch into an Isolated Windows Environment failed because the environment isn't available.

### -field FileNotFound:3

File launch into an Isolated Windows Environment failed because the file was not found.

### -field TimedOut:4

File launch into an Isolated Windows Environment timed out.

### -field AlreadySharedWithConflictingOptions: 5

File was previously shared with invalid/conflicting options. For example, if a file is shared previously with the [ShareFileAsync](isolatedwindowsenvironment_sharefileasync_1722827044.md) call and AllowWrite in [IsolatedWindowsEnvironmentShareFileRequestOptions](isolatedwindowsenvironmentsharefilerequestoptions.md) is false, this error will be thrown.

## -remarks

> [!WARNING]
> This is a deprecated API.

## -see-also

[IsolatedWindowsEnvironmentShareFileRequestOptions](isolatedwindowsenvironmentsharefilerequestoptions.md), [ShareFileAsync](isolatedwindowsenvironment_sharefileasync_1722827044.md)

## -examples
