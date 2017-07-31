---
-api-id: P:Windows.Security.EnterpriseData.FileProtectionInfo.IsProtectWhileOpenSupported
-api-type: winrt property
---

<!-- Property syntax.
public bool IsProtectWhileOpenSupported { get; }
-->

# Windows.Security.EnterpriseData.FileProtectionInfo.IsProtectWhileOpenSupported

## -description
Determines whether your app can protect a file while it is open.

## -property-value
**true** if your app can protect a file while it is open, or **false** if that capability is not supported on the device.

## -remarks
If this property returns **true**, you can protect a file while the file is open.

This can be useful if users open a file that is not protected and attempt to paste enterprise protected information into it. You can protect the open file and save users from having to respond to a prompt or, depending on the level of policy enforcement, save them from being blocked from pasting content completely.

## -see-also

## -examples
