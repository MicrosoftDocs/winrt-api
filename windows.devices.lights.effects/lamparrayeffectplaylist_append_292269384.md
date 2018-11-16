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
Once an effect has been Appended, it cannot be Appended to a second playlist. A new instance of the effect must be created.

After playlist has started, the state is locked and is not possible to Append further effects.

## -see-also

## -examples

