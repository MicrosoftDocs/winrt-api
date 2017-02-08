---
-api-id: P:Windows.UI.WebUI.WebUILaunchActivatedEventArgs.TileId
-api-type: winrt property
---

<!-- Property syntax
public string TileId { get; }
-->

# Windows.UI.WebUI.WebUILaunchActivatedEventArgs.TileId

## -description
Gets the ID of the source that was invoked to launch the application.

## -property-value
The ID of the tile.

## -remarks
As an example, if the user touches a tile to launch the app, then the source ID retrieved through this property is the tile's ID. The ID of an app's primary tile is the same as its AppUserModelId. Secondary tiles have an ID that is specified when they are created. Most other UI elements will set the source ID as the AppuserModelId of the app.

## -examples

## -see-also
