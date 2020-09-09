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
> Stating that your secondary tile is eligible for a lock screen presence does not guarantee that it will have one. Only the user can add an app to one of the seven lock screen slots. For more information, see the [Lock screen overview](/previous-versions/windows/apps/hh779720(v=win.10)).

## -property-value
A Uniform Resource Identifier (URI) that specifies the logo image file location.

## -remarks

## -examples

## -see-also