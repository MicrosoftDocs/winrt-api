---
-api-id: M:Windows.Devices.Lights.Effects.LampArrayEffectPlaylist.OverrideZIndex(System.Int32)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public void LampArrayEffectPlaylist.OverrideZIndex(Int32 zIndex)
-->

# Windows.Devices.Lights.Effects.LampArrayEffectPlaylist.OverrideZIndex

## -description
Overrides the zIndex for all contained effects.

## -parameters
### -param zIndex
The overriding zIndex.

## -remarks
Effects added after OverrideZIndex is called will still be overridden.

After the playlist has started, all zIndexes are locked and it's not possible to override further.

## -see-also

## -examples

