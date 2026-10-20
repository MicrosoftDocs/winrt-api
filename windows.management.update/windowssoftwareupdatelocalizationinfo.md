---
-api-id: T:Windows.Management.Update.WindowsSoftwareUpdateLocalizationInfo
-api-type: winrt class
---

# Windows.Management.Update.WindowsSoftwareUpdateLocalizationInfo

<!--
public sealed class WindowsSoftwareUpdateLocalizationInfo
-->


## -description

Provides a localized title, description, and *more info* URL for a [WindowsSoftwareUpdate](./windowssoftwareupdate.md) in a specific language.

## -remarks

A provider can supply one localization entry per language. The system selects the entry that matches the user's display language when presenting the update; if no match is found, the update's default title and description are used.

## -see-also

[WindowsSoftwareUpdateOptionalInfo](./windowssoftwareupdateoptionalinfo.md), [WindowsSoftwareUpdate](./windowssoftwareupdate.md)

## -examples

