---
-api-id: T:Windows.UI.StartScreen.SecondaryTile
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class SecondaryTile : Windows.UI.StartScreen.ISecondaryTile, Windows.UI.StartScreen.ISecondaryTile2
-->

# Windows.UI.StartScreen.SecondaryTile

## -description

Creates, enumerates, and provides information about a secondary tile.

In a desktop app, before using an instance of this class in a way that displays UI, you'll need to associate the object with its owner's window handle. For more info, and code examples, see [Display WinRT UI objects that depend on CoreWindow](/windows/apps/develop/ui-input/display-ui-objects#winui-3-with-c) and [Pin secondary tiles from desktop apps](/windows/apps/design/shell/tiles-and-notifications/secondary-tiles-desktop-pinning).

## -remarks

## -examples

The following example creates and pins a secondary tile to the Start screen.

```csharp
using Windows.UI.StartScreen;

// Prepare package images for all four tile sizes in our tile to be pinned as well as for the square30x30 logo used in the Apps view.  
Uri square150x150Logo = new Uri("ms-appx:///Assets/square150x150Tile-sdk.png");
Uri wide310x150Logo = new Uri("ms-appx:///Assets/wide310x150Tile-sdk.png");
Uri square310x310Logo = new Uri("ms-appx:///Assets/square310x310Tile-sdk.png"); 
Uri square30x30Logo = new Uri("ms-appx:///Assets/square30x30Tile-sdk.png");

// During creation of secondary tile, an application may set additional arguments on the tile that will be passed in during activation.
// These arguments should be meaningful to the application. In this sample, we'll pass in the date and time the secondary tile was pinned.
string tileActivationArguments = MainPage.logoSecondaryTileId + " WasPinnedAt=" + DateTime.Now.ToLocalTime().ToString();

// Create a Secondary tile with all the required arguments.
// Note the last argument specifies what size the Secondary tile should show up as by default in the Pin to start fly out.
// It can be set to TileSize.Square150x150, TileSize.Wide310x150, or TileSize.Default.  
// If set to TileSize.Wide310x150, then the asset for the wide size must be supplied as well.
// TileSize.Default will default to the wide size if a wide size is provided, and to the medium size otherwise. 
SecondaryTile secondaryTile = new SecondaryTile(MainPage.logoSecondaryTileId,
                                                "Title text shown on the tile",
                                                tileActivationArguments,
                                                square150x150Logo,
                                                TileSize.Square150x150);

// Pin the tile
bool isPinned = await tile.RequestCreateAsync();
if (isPinned) {
    // Secondary tile successfully pinned.
} 
else {
    // Secondary tile not pinned.
}

```

The following example demonstrates how to delete (unpin) a secondary tile by using the [RequestDeleteAsync](secondarytile_requestdeleteasync_880835933.md) method. Note that this example assumes that the tile exists. To determine whether the tile is pinned before you call [RequestDeleteAsync](secondarytile_requestdeleteasync_880835933.md), see the [Exists](secondarytile_exists_1536819090.md) method.

```csharp
// Check if the secondary tile is pinned
if (SecondaryTile.Exists(tileId)) {
    // Initialize a secondary tile with the same tile ID you want removed
    SecondaryTile toBeDeleted = new SecondaryTile(tileId);

    // And then unpin the tile
    bool isDeleted = await toBeDeleted.RequestDeleteAsync();
    if (isDeleted) {
        // Secondary tile successfully deleted.
    } else {
        // Secondary tile not deleted.
    }
}
```

The following example demonstrates how to use the [FindAllForPackageAsync](secondarytile_findallforpackageasync_2029224098.md) method to retrieve a list of IDs for all secondary tiles created for the calling app and any other app in the same package.

```csharp
// Get all secondary tiles
var tiles = await SecondaryTile.FindAllForPackageAsync();
```

The following example demonstrates how to use the [TileUpdateManager.createTileUpdaterForSecondaryTile](../windows.ui.notifications/tileupdatemanager_createtileupdaterforsecondarytile_445640521.md) method to send a notification to a secondary tile with an ID of "SecondaryTile.Dynamic". Note that the example provides both a wide and square version of the notification because the user has control over which form of the tile is showing.

```csharp
using NotificationsExtensions.TileContent;

// Define the notification context.
// Note: This sample contains an additional reference, NotificationsExtensions, which you can use in your apps
ITileWide310x150Text04 tileContent = TileContentFactory.CreateTileWide310x150Text04();
tileContent.TextBodyWrap.Text = "Sent to a secondary tile from NotificationsExtensions!";

// Provide a square version of the notification.
ITileSquare150x150Text04 squareContent = TileContentFactory.CreateTileSquare150x150Text04();
squareContent.TextBodyWrap.Text = "Sent to a secondary tile from NotificationExtensions!";
tileContent.Square150x150Content = squareContent;

// Send the notification to the secondary tile by creating a secondary tile updater
TileUpdateManager.CreateTileUpdaterForSecondaryTile(MainPage.dynamicTileId).Update(tileContent.CreateNotification());
```

The following example demonstrates how to use the [BadgeUpdateManager.createBadgeUpdaterForSecondaryTile](../windows.ui.notifications/badgeupdatemanager_createbadgeupdaterforsecondarytile_131286133.md) method to send a numeric badge notification to a secondary tile with an ID of "SecondaryTile.Dynamic".

```csharp
using NotificationsExtensions.BadgeContent;

// Define the badge content
BadgeNumericNotificationContent badgeContent = new BadgeNumericNotificationContent(6);

// Send the notification to the secondary tile
BadgeUpdateManager.CreateBadgeUpdaterForSecondaryTile(MainPage.dynamicTileId).Update(badgeContent.CreateNotification());

```

## -see-also

[Secondary tiles guidance](/windows/uwp/design/shell/tiles-and-notifications/secondary-tiles), [Secondary tiles sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SecondaryTiles), [Mixed Reality Model sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/MixedRealityModel)
