---
-api-id: P:Windows.Management.Update.WindowsUpdateRestartRequestOptions.OptOutOfAutoReboot
-api-type: winrt property
---

# Windows.Management.Update.WindowsUpdateRestartRequestOptions.OptOutOfAutoReboot

<!--
public bool OptOutOfAutoReboot { get; set; }
-->


## -description
Indicates whether or not the update should opt out of the auto reboot flow.

## -property-value

## -remarks
If this is true, the device will attempt to automatically restart overnight when the end user is away.

If a boolean value of false is specified, then the device will not automatically restart when the end user is away. The end user will see a variety of notifications asking them to `schedule the restart`, `restart now`, or `restart tonight` and then will become progressively more demanding in terms of notification language and frequency as they near the forced restart.

## -see-also

## -examples


