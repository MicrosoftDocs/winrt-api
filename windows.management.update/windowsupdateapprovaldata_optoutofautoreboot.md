---
-api-id: P:Windows.Management.Update.WindowsUpdateApprovalData.OptOutOfAutoReboot
-api-type: winrt property
---

# Windows.Management.Update.WindowsUpdateApprovalData.OptOutOfAutoReboot

<!--
public System.Nullable<bool> OptOutOfAutoReboot { get; set; }
-->


## -description

Gets or sets a value indicating whether the update should opt out of the auto reboot flow.

## -property-value

A value indicating whether the update should opt out of the auto reboot flow.

## -remarks

If this property value is `true`, then the device will attempt to automatically restart overnight when the end user is away.

If a Boolean value of `false` is specified, then the device won't automatically restart when the end user is away. The end user will see a variety of notifications asking them to "schedule the restart", "restart now", or "restart tonight", and they will become progressively more demanding in terms of notification language and frequency as they near the forced restart.

## -see-also

## -examples
