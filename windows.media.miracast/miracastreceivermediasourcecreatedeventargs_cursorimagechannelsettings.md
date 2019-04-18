---
-api-id: P:Windows.Media.Miracast.MiracastReceiverMediaSourceCreatedEventArgs.CursorImageChannelSettings
-api-type: winrt property
ms.custom: 19H1
---

<!-- Property syntax.
public MiracastReceiverCursorImageChannelSettings CursorImageChannelSettings { get; }
-->

# Windows.Media.Miracast.MiracastReceiverMediaSourceCreatedEventArgs.CursorImageChannelSettings

## -description

Returns an object for configuring the settings of the optional cursor image channel.

## -property-value

The [MiracastReceiverCursorImageChannelSettings](miracastreceivercursorimagechannelsettings.md) object.

## -remarks

The configuration settings for the cursor image channel take effect when the event is completed. Use [MiracastReceiverMediaSourceCreatedEventArgs.GetDeferral](miracastreceivermediasourcecreatedeventargs_getdeferral_254836512.md) to delay the completion of the event, if needed.

## -see-also

[MiracastReceiverCursorImageChannelSettings](miracastreceivercursorimagechannelsettings.md)

## -examples

