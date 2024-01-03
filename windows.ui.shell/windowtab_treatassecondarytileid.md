---
-api-id: P:Windows.UI.Shell.WindowTab.TreatAsSecondaryTileId
-api-type: winrt property
---

# Windows.UI.Shell.WindowTab.TreatAsSecondaryTileId

<!--
public string TreatAsSecondaryTileId { get; set; }
-->

## -description

Gets or sets a string that identifies a [SecondaryTile](../windows.ui.startscreen/secondarytile.md) used by your app. Setting this property indicates that the tab should be treated as if opened by the secondary tile.

## -property-value

A string that matches a [SecondaryTile.TileId](../windows.ui.startscreen/secondarytile_tileid.md) used by your app.

## -remarks

> [!IMPORTANT]
> This API is for Win32 desktop apps only. UWP and other app types are not supported.

If your app uses a [SecondaryTile](../windows.ui.startscreen/secondarytile.md), you can set this property to associate the tab with it. The tab will be treated as if it were launched by the `SecondaryTile`.

For more info, see [Secondary tiles](/windows/apps/design/shell/tiles-and-notifications/secondary-tiles), the [SecondaryTile](../windows.ui.startscreen/secondarytile.md) class, and the [SecondaryTile.TileId](../windows.ui.startscreen/secondarytile_tileid.md) property.

## -see-also

[Secondary tiles](/windows/apps/design/shell/tiles-and-notifications/secondary-tiles), [SecondaryTile](../windows.ui.startscreen/secondarytile.md), [SecondaryTile.TileId](../windows.ui.startscreen/secondarytile_tileid.md)

## -examples
