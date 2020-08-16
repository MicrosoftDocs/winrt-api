---
-api-id: P:Windows.Devices.Lights.Effects.LampArrayBitmapEffect.ZIndex
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public int ZIndex { get;  set; }
-->

# Windows.Devices.Lights.Effects.LampArrayBitmapEffect.ZIndex

## -description
Gets or sets the global precedence (across all playlists) for two effects that modify the same lamp (on the same [LampArray](../windows.devices.lights/lamparray.md)).

## -property-value
Default value is 0.

## -remarks
Higher zIndex implies higher precedence.

If two effects with the same zIndex operate on the same lamp (via two separate [LampArrayEffectPlaylists](lamparrayeffectplaylist.md)), the behavior is undefined.

After you've appended (see [Append](lamparrayeffectplaylist_append_292269384.md)) an effect to a [LampArrayEffectPlaylist](lamparrayeffectplaylist.md), the value of this property is locked, and you can no longer change it.

## -see-also

## -examples

