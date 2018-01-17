---
-api-id: P:Windows.UI.StartScreen.SecondaryTile.LockScreenDisplayBadgeAndTileText
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public bool LockScreenDisplayBadgeAndTileText { get;  set; }
-->

# Windows.UI.StartScreen.SecondaryTile.LockScreenDisplayBadgeAndTileText

## -description
Gets or sets whether the secondary tile is eligible to display both a badge and a detailed tile on the lock screen. If you set this property to **True**, you must also provide a badge image through the [LockScreenBadgeLogo](secondarytile_lockscreenbadgelogo.md) property. If you do not want to use the detailed tile capability, provide a badge image through the [LockScreenBadgeLogo](secondarytile_lockscreenbadgelogo.md) property and set [LockScreenDisplayBadgeAndTileText](secondarytile_lockscreendisplaybadgeandtiletext.md) to **False**.

> [!NOTE]
> Stating that your secondary tile is eligible for a lock screen presence does not guarantee that it will have one. Only the user can add an app to one of the seven lock screen slots, as well as choosing which one of them can display detailed tile information. For more information, see the [Lock screen overview](http://msdn.microsoft.com/library/07fefb48-f55c-4ab7-8b68-a8aed11074fd).

## -property-value
**True** if the secondary tile can have a lock screen presence; otherwise, **False**.

## -remarks

## -examples

## -see-also