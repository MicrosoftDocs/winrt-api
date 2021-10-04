---
-api-id: T:Windows.ApplicationModel.FullTrustLaunchResult
-api-type: winrt enum
---

# Windows.ApplicationModel.FullTrustLaunchResult

<!--
public enum FullTrustLaunchResult
-->


## -description

Specifies the result status of the full trust process launch operation.

## -enum-fields

### -field Success: 0

The operation was successful

### -field AccessDenied: 1

The calling app does not have permission to execute the operation.

### -field FileNotFound: 2

The file associated with the operation was not found.

### -field Unknown: 3

The operation failed for unknown reasons.

## -remarks

Values from this enumeration are used by the [FullTrustProcessLaunchResult](fulltrustprocesslaunchresult.md) object, which is obtained through calls to the following methods.

- [LaunchFullTrustProcessForAppWithArgumentsAsync](fulltrustprocesslauncher_launchfulltrustprocessforappwithargumentsasync_783196823.md)
- [LaunchFullTrustProcessForCurrentAppWithArgumentsAsync](fulltrustprocesslauncher_launchfulltrustprocessforcurrentappwithargumentsasync_1868807952.md)

## -see-also

## -examples


