---
-api-id: P:Windows.Management.Update.WindowsUpdateRestartRequestOptions.ComplianceDeadlineInDays
-api-type: winrt property
---

# Windows.Management.Update.WindowsUpdateRestartRequestOptions.ComplianceDeadlineInDays

<!--
public int ComplianceDeadlineInDays { get; set; }
-->


## -description
Indicates the compliance deadline in days before a reboot must occur to complete the update.

## -property-value

## -remarks
The end user will have the number of days specified by `ComplianceDeadlineInDays` to take the reboot. The end user will then be forced to reboot after the number of days specified by `ComplianceGracePeriodInDays` have passed. Prior to this deadline being reached, the device will attempt to automatically restart overnight when the end user is away. This will happen if the boolean value of true is specified for `OptOutOfAutoReboot`. If a boolean value of false is specified, then the device will not automatically restart when the end user is away. The end user will see a variety of notifications asking them to `schedule the restart`, `restart now`, or `restart tonight` and then will become progressively more demanding in terms of notification language and frequency as they near the forced restart.

## -see-also

## -examples


