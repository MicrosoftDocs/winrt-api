---
-api-id: M:Windows.Devices.Lights.Effects.LampArrayEffectPlaylist.IndexOf(Windows.Devices.Lights.Effects.ILampArrayEffect,System.UInt32@)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public bool LampArrayEffectPlaylist.IndexOf(ILampArrayEffect value, UInt32 index)
-->

# Windows.Devices.Lights.Effects.LampArrayEffectPlaylist.IndexOf

## -description

Retrieves the index, within a playlist, of the specified lamp array effect.

## -parameters

### -param value

An [ILampArrayEffect](ilamparrayeffect.md) representing the lamp array effect whose index to retrieve.

### -param index

The index of the effect within the playlist, as an out parameter. If the *value* is found, then the method will update *index* with the zero-based index of the effect within the playlist.

## -returns

`true` if the effect is found, otherwise `false`.

## -remarks

## -examples

## -see-also