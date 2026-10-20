---
-api-id: T:Windows.Management.Update.WindowsSoftwareUpdateCategory
-api-type: winrt enum
---

# Windows.Management.Update.WindowsSoftwareUpdateCategory

<!--
public enum WindowsSoftwareUpdateCategory
-->


## -description

Defines constants that classify a [WindowsSoftwareUpdate](./windowssoftwareupdate.md) by the kind of payload it delivers.

## -enum-fields

### -field Other: 0
The update doesn't fall into any of the more specific categories.

### -field Application: 1
The update services an installed application.

### -field Driver: 2
The update services a device driver.

### -field Firmware: 3
The update services device firmware.

### -field Definition: 4
The update delivers definition content, such as antimalware definitions.

### -field Feature: 5
The update delivers a feature update.

### -field Quality: 6
The update delivers a quality (servicing) update.

### -field AIComponent: 7
The update services an AI component.

## -remarks

The category is surfaced to the orchestrator and the user experience to help describe and group updates. It's supplied through [WindowsSoftwareUpdateOptionalInfo](./windowssoftwareupdateoptionalinfo.md).

## -see-also

[WindowsSoftwareUpdate](./windowssoftwareupdate.md), [WindowsSoftwareUpdateOptionalInfo](./windowssoftwareupdateoptionalinfo.md)

## -examples

