---
-api-id: M:Windows.Devices.Lights.Effects.LampArrayEffectPlaylist.Append(Windows.Devices.Lights.Effects.ILampArrayEffect)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public void LampArrayEffectPlaylist.Append(ILampArrayEffect effect)
-->

# Windows.Devices.Lights.Effects.LampArrayEffectPlaylist.Append

## -description
Appends the effect to the end of the playlist.

## -parameters

### -param effect
Effect to append to the playlist.

## -remarks
Once an effect has been appended to a playlist, it cannot be appended to another. Instead, you must create a new instance of the effect.

After a playlist has started, its state is locked, and you can't append further effects to it.

## -examples

## -see-also