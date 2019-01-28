---
-api-id: M:Windows.Devices.Lights.Effects.LampArrayEffectPlaylist.StopAll(Windows.Foundation.Collections.IIterable{Windows.Devices.Lights.Effects.LampArrayEffectPlaylist})
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public void LampArrayEffectPlaylist.StopAll(IIterable<LampArrayEffectPlaylist> value)
-->

# Windows.Devices.Lights.Effects.LampArrayEffectPlaylist.StopAll

## -description
Guarantees that all playlists will stop at the same time.

## -parameters
### -param value
Playlists to stop simultaneously.

## -remarks
This removes the small lag time that occurs if called on each [LampArrayEffectPlaylist](lamparrayeffectplaylist.md) from within a for-loop.

## -see-also

## -examples

