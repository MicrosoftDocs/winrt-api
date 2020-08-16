---
-api-id: M:Windows.Devices.Lights.Effects.LampArrayEffectPlaylist.PauseAll(Windows.Foundation.Collections.IIterable{Windows.Devices.Lights.Effects.LampArrayEffectPlaylist})
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public void LampArrayEffectPlaylist.PauseAll(IIterable<LampArrayEffectPlaylist> value)
-->

# Windows.Devices.Lights.Effects.LampArrayEffectPlaylist.PauseAll

## -description

Guarantees that all playlists will pause at the same time.

## -parameters

### -param value

Playlists to pause simultaneously.

## -remarks

This removes the small time lag that occurs if called on each [LampArrayEffectPlaylist](lamparrayeffectplaylist.md) from within a for-loop.

## -see-also

## -examples

