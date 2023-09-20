---
-api-id: P:Windows.Management.Update.WindowsUpdateApprovalData.ComplianceDeadlineInDays
-api-type: winrt property
---

# Windows.Management.Update.WindowsUpdateApprovalData.ComplianceDeadlineInDays

<!--
public System.Nullable<int> ComplianceDeadlineInDays { get; set; }
-->


## -description

Gets or sets a value indicating the compliance deadline in days before a reboot must occur in order to complete the update.

## -property-value

A value indicating the compliance deadline in days before a reboot must occur in order to complete the update.

## -remarks

The end user will have the number of days specified by **ComplianceDeadlineInDays** in which to take the reboot. The end user will then be forced to reboot after the number of days specified by **ComplianceGracePeriodInDays** have passed. Prior to this deadline being reached, the device will attempt to automatically restart overnight when the end user is away. That will happen if the Boolean value of `true` is specified for **OptOutOfAutoReboot**. If a Boolean value of `false` is specified, then the device will not automatically restart when the end user is away. The end user will see a variety of notifications asking them to "schedule the restart", "restart now", or "restart tonight", and they will become progressively more demanding in terms of notification language and frequency as they near the forced restart.

If an update doesn't require a reboot to complete, then this field will have no effect.

## -see-also

## -examples
