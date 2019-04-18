---
-api-id: M:Windows.Media.Miracast.MiracastReceiver.DisconnectAllAndApplySettings(Windows.Media.Miracast.MiracastReceiverSettings)
-api-type: winrt method
ms.custom: 19H1
---

<!-- Method syntax.
public MiracastReceiverApplySettingsResult MiracastReceiver.DisconnectAllAndApplySettings(MiracastReceiverSettings settings)
-->

# Windows.Media.Miracast.MiracastReceiver.DisconnectAllAndApplySettings

## -description

Disconnects all currently connected Miracast connections and applies the specified settings on the [MiracastReceiver](miracastreceiver.md).

## -parameters
### -param settings

The settings that will be applied.

## -returns

A [MiracastReceiverApplySettingsResult](miracastreceiverapplysettingsresult.md) containing information about the result of the operation.

## -remarks

Because this method may block for a noticeable period of time, you should not call it from the UI thread or from a single-threaded apartment. Instead, use the asyncronous method [DisconnectAllAndApplySettingsAsync](miracastreceiver_disconnectallandapplysettingsasync_404771925.md).

Check the [MiracastReceiverApplySettingsResult](miracastreceiverapplysettingsresult.md) return parameter to confirm that the settings were
successfully applied. If Miracast has been enabled by the operating system, such as through the Settings app,
changes to the settings will not be allowed and the **MiracastReceiverApplySettingsResult** return value will 
indicate that access was denied.

## -see-also

[DisconnectAllAndApplySettingsAsync](miracastreceiver_disconnectallandapplysettingsasync_404771925.md),
[MiracastReceiverApplySettingsResult](miracastreceiverapplysettingsresult.md)

## -examples

