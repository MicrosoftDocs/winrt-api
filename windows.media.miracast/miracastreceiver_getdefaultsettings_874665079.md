---
-api-id: M:Windows.Media.Miracast.MiracastReceiver.GetDefaultSettings
-api-type: winrt method
ms.custom: 19H1
---

<!-- Method syntax.
public MiracastReceiverSettings MiracastReceiver.GetDefaultSettings()
-->

# Windows.Media.Miracast.MiracastReceiver.GetDefaultSettings

## -description

Returns default settings for the [MiracastReceiver](miracastreceiver.md).

## -returns

A [MiracastReceiverSettings](miracastreceiversettings.md) object containing information about the default settings for the **MiracastReceiver**.

## -remarks

Apps can invoke **GetDefaultSettings** to receive a [MiracastReceiverSettings](miracastreceiversettings.md) object populated with the default settings.
Apps can then modify the values from the defaults and then pass the settings object as a parameter to the [DisconnectAllAndApplySettingsAsync](miracastreceiver_disconnectallandapplysettingsasync_404771925.md) call.

## -see-also

[DisconnectAllAndApplySettingsAsync](miracastreceiver_disconnectallandapplysettingsasync_404771925.md)

## -examples

