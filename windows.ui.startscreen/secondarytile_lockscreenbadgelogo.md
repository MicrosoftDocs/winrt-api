---
-api-id: P:Windows.UI.StartScreen.SecondaryTile.LockScreenBadgeLogo
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Foundation.Uri LockScreenBadgeLogo { get;  set; }
-->

# Windows.UI.StartScreen.SecondaryTile.LockScreenBadgeLogo

## -description
Gets or sets the location of a badge logo image to represent the secondary tile on the lock screen. By supplying this image, you declare that the secondary tile is eligible to display a badge on the lock screen. If you also want the secondary tile to be eligible for the lock screen's detailed tile slot, you must also set the [LockScreenDisplayBadgeAndTileText](secondarytile_lockscreendisplaybadgeandtiletext.md) property to **True**.

> [!NOTE]
> Stating that your secondary tile is eligible for a lock screen presence does not guarantee that it will have one. Only the user can add an app to one of the seven lock screen slots. For more information, see the [Lock screen overview](http://msdn.microsoft.com/library/07fefb48-f55c-4ab7-8b68-a8aed11074fd).

## -property-value
A Uniform Resource Identifier (URI) that specifies the logo image file location.

## -remarks

## -examples

## -see-also
[Secondary tiles overview](http://msdn.microsoft.com/library/973391ca-a4f1-40f7-a909-5396b4a2bd18), [Lock screen overview](http://msdn.microsoft.com/library/07fefb48-f55c-4ab7-8b68-a8aed11074fd), [Secondary tiles sample](http://go.microsoft.com/fwlink/p/?linkid=231487), [Lock screen app sample](http://go.microsoft.com/fwlink/p/?linkid=239970), [Guidelines and checklist for secondary tiles](http://msdn.microsoft.com/library/8be09bc3-d052-4d61-aab9-fbbf5c70b6e0), [Guidelines and checklist for tiles and badges](http://msdn.microsoft.com/library/e825f754-97dd-41c2-aff4-4dfb60eda677), [Quickstart: Showing tile and badge updates on the lock screen](http://msdn.microsoft.com/library/c74688bd-7ff8-4171-8903-f44e0ad03667), [How to send notifications to a secondary tile](http://msdn.microsoft.com/library/168d2a8a-3348-48d4-9973-da4537322d27), [Quickstart: Pinning a secondary tile](http://msdn.microsoft.com/library/813ff906-3c8b-4c9f-9e3a-7315fbb9ec17), [Pinning secondary tiles](http://msdn.microsoft.com/library/54a4d4d3-0430-45eb-b5fd-ee96598c216e)