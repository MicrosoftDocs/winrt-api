---
-api-id: M:Windows.Media.Miracast.MiracastReceiver.GetCurrentSettings
-api-type: winrt method
ms.custom: 19H1
---

<!-- Method syntax.
public MiracastReceiverSettings MiracastReceiver.GetCurrentSettings()
-->

# Windows.Media.Miracast.MiracastReceiver.GetCurrentSettings

## -description

Returns the settings currently used by the [MiracastReceiver](miracastreceiver.md).

## -returns

A [MiracastReceiverApplySettingsResult](miracastreceiverapplysettingsresult.md) containing information about the current settings used by the **MiracastReceiver**.

## -remarks

Because this method may block for a noticeable period of time, you should not call it from the UI thread or from a single-threaded apartment. Instead, use the asyncronous method [GetCurrentSettingsAsync](miracastreceiver_getcurrentsettingsasync_189471090.md).

## -see-also

[GetCurrentSettingsAsync](miracastreceiver_getcurrentsettingsasync_189471090.md)

## -examples

