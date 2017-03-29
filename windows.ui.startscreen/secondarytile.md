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

## -remarks

## -examples
The following example creates and pins a secondary tile to the Start screen.

```javascript

// Prepare package images for use as the Tile Logo and Small Logo in our tile to be pinned.
var uriLogo = new Windows.Foundation.Uri("ms-appx:///images/SecondaryTileDefault-sdk.png");
var uriSmallLogo = new Windows.Foundation.Uri("ms-appx:///images/smallLogoSecondaryTile-sdk.png");

// Create a tile to be be pinned.

// During creation of secondary tiles, an application can set additional arguments on the tile 
// that will be passed in during activation. These arguments should be meaningful to the application. 
// In this example, we'll pass in the date and time that the Secondary Tile was pinned.
var currentTime = new Date();
var tileActivationArguments = "timeTileWasPinned=" + currentTime;

// Specify the short name to display on the tile, the display name, arguments to be passed in 
// during activation, attributes regarding how to display the tile by default, and the tile logo.
// Note that you should pick a unique ID that is descriptive and meaningful to your application. 
// In this case, we explicitly code a single ID to focus our attention on the pinning operation.

var tile = new Windows.UI.StartScreen.SecondaryTile("SecondaryTile.01", 
                                                    "A Secondary Tile", 
                                                    "Secondary Tile Sample Secondary Tile", 
                                                    tileActivationArguments, 
                                                    Windows.UI.StartScreen.TileOptions.showNameOnLogo, 
                                                    uriLogo);

// Specify a foreground text value.
// The secondary tile background color over which this text is shown is inherited from the 
// parent app unless a separate value is specified.
tile.foregroundText = Windows.UI.StartScreen.ForegroundText.dark;

// The small tile logo is inherited from the parent app unless overridden as we do here.
tile.smallLogo = uriSmallLogo;

// Attempt to pin the tile.
// Note that the status message is updated when the async operation to pin the tile completes.

tile.requestCreateAsync().then(function (isCreated) {
    if (isCreated) {
        // Secondary tile successfully pinned.
    } else {
        // Secondary tile not pinned.
    }
});
```

The following example demonstrates how to delete (unpin) a secondary tile by using the [RequestDeleteAsync](secondarytile_requestdeleteasync_880835933.md) method. Note that this example assumes that the tile exists. To determine whether the tile is pinned before you call [RequestDeleteAsync](secondarytile_requestdeleteasync_880835933.md), see the [Exists](secondarytile_exists.md) method.

```javascript

// Specify the secondary tile to be deleted, using the ID that it was given when it was originally created.
var tileToBeDeleted = new Windows.UI.StartScreen.SecondaryTile("SecondaryTile.01");

// Make the delete request.
tileToBeDeleted.requestDeleteAsync().then(function (isDeleted) {
    if (isDeleted) {
        // Secondary tile successfully deleted.
    } else {
        // Secondary tile not deleted.
    }
});
```

The following example demonstrates how to use the [FindAllForPackageAsync](secondarytile_findallforpackageasync.md) method to retrieve a list of IDs for all secondary tiles created for the calling app and any other app in the same package.

```javascript

Windows.UI.StartScreen.SecondaryTile.findAllForPackageAsync().done(function (tiles) {
    tiles.forEach(function (tile) {
        var myTileId = tile.tileId;
        // Continue to process as necessary.
    });
});
```

The following example demonstrates how to use the [TileUpdateManager.createTileUpdaterForSecondaryTile](../windows.ui.notifications/tileupdatemanager_createtileupdaterforsecondarytile.md) method to send a notification to a secondary tile with an ID of "SecondaryTile.Dynamic". Note that the example provides both a wide and square version of the notification because the user has control over which form of the tile is showing.

```javascript

var notifications = Windows.UI.Notifications;

// Define the notification content.
var tileXml = notifications.TileUpdateManager.getTemplateContent(notifications.TileTemplateType.tileWide310x150Text04);
var tileTextAttributes = tileXml.getElementsByTagName("text");
tileTextAttributes[0].appendChild(tileXml.createTextNode("Sent to a secondary tile!"));

// Provide a square version of the notification.
var squareTileXml = notifications.TileUpdateManager.getTemplateContent(notifications.TileTemplateType.tileSquare150x150Text04);
var squareTileTextAttributes = squareTileXml.getElementsByTagName("text");
squareTileTextAttributes[0].appendChild(squareTileXml.createTextNode("Sent to a secondary tile!"));

// Add the medium tile to the notification.
var node = tileXml.importNode(squareTileXml.getElementsByTagName("binding").item(0), true);
tileXml.getElementsByTagName("visual").item(0).appendChild(node);

// Create the notification based on the XML content.
var tileNotification = new notifications.TileNotification(tileXml);

// Create a secondary tile updater, passing it the ID of the tile.
var tileUpdater = notifications.TileUpdateManager.createTileUpdaterForSecondaryTile("SecondaryTile.Dynamic");

// Send the notification to the secondary tile.
tileUpdater.update(tileNotification);
```

The following example demonstrates how to use the [BadgeUpdateManager.createBadgeUpdaterForSecondaryTile](../windows.ui.notifications/badgeupdatemanager_createbadgeupdaterforsecondarytile.md) method to send a numeric badge notification to a secondary tile with an ID of "SecondaryTile.Dynamic".

```javascript

var notifications = Windows.UI.Notifications;

// Define the badge content
var badgeNotification = notifications.BadgeUpdateManager.getTemplateContent(notifications.BadgeTemplateType.badgeNumber);
var badgeAttributes = badgeNotification.getElementsByTagName("badge");
badgeAttributes[0].setAttribute("value", "6");

// Create the notification based on the XML content.
var badge = new notifications.BadgeNotification(badgeNotification);

// Create a secondary tile updater, passing it the ID of the tile.
notifications.BadgeUpdateManager.createBadgeUpdaterForSecondaryTile("SecondaryTile.Dynamic");

// Send the notification to the secondary tile.
tileUpdater.update(tileNotification);
```



## -see-also
[Secondary tiles sample](http://go.microsoft.com/fwlink/p/?linkid=231487), [Secondary tiles sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620593)