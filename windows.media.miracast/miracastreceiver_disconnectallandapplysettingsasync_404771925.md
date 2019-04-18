---
-api-id: M:Windows.Media.Miracast.MiracastReceiver.DisconnectAllAndApplySettingsAsync(Windows.Media.Miracast.MiracastReceiverSettings)
-api-type: winrt method
ms.custom: 19H1
---

<!-- Method syntax.
public IAsyncOperation<MiracastReceiverApplySettingsResult> MiracastReceiver.DisconnectAllAndApplySettingsAsync(MiracastReceiverSettings settings)
-->

# Windows.Media.Miracast.MiracastReceiver.DisconnectAllAndApplySettingsAsync

## -description

Asynchronously disconnects all currently connected Miracast connections and applies the specified settings on the [MiracastReceiver](miracastreceiver.md).

## -parameters
### -param settings

The settings that will be applied.

## -returns

An asynchronous operation that returns a **MiracastReceiverApplySettingsResult** object upon completion.

## -remarks

Check the [MiracastReceiverApplySettingsResult](miracastreceiverapplysettingsresult.md) return parameter to confirm that the settings were
successfully applied. If Miracast has been enabled by the operating system, such as through the Settings app,
changes to the settings will not be allowed and the **MiracastReceiverApplySettingsResult** return value will 
indicate that access was denied.

## -see-also

[DisconnectAllAndApplySettings](miracastreceiver_disconnectallandapplysettings_1413841516.md)

## -examples

