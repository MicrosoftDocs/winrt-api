---
-api-id: M:Windows.Devices.Lights.Effects.LampArrayEffectPlaylist.StartAll(Windows.Foundation.Collections.IIterable{Windows.Devices.Lights.Effects.LampArrayEffectPlaylist})
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public void LampArrayEffectPlaylist.StartAll(IIterable<LampArrayEffectPlaylist> value)
-->

# Windows.Devices.Lights.Effects.LampArrayEffectPlaylist.StartAll

## -description
Guarantees that all playlists will start at the same time.

## -parameters
### -param value
Playlists to start simultaneously.

## -remarks
This removes the small lag time that occurs if called on each [LampArrayEffectPlaylist](lamparrayeffectplaylist.md) from within a for-loop.

## -see-also

## -examples

