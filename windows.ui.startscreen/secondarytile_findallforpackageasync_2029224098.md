---
-api-id: M:Windows.UI.StartScreen.SecondaryTile.FindAllForPackageAsync
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.UI.StartScreen.SecondaryTile>> FindAllForPackageAsync()
-->

# Windows.UI.StartScreen.SecondaryTile.FindAllForPackageAsync

## -description
Retrieves a list of secondary tiles created for all of the apps in the package of the calling app.

When an app launches, it should always enumerate its secondary tiles through this method, in case there were any additions or deletions of which it was unaware. When a secondary tile is deleted through the Start screen app bar, Windows simply removes the tile. The app itself is responsible for releasing any resources that were used by the secondary tile. When secondary tiles are copied through the cloud, current tile or badge notifications on the secondary tile, scheduled notifications, push notification channels, and Uniform Resource Identifier (URI) used with periodic notifications are not copied with the secondary tile and must be reset up.

## -returns
An enumeration object that allows you to examine the set of tiles.

## -remarks
This method returns a collection of tile IDs through an instance of the [IAsyncOperation](../windows.foundation/iasyncoperation_1.md) interface. When the asynchronous operation completes successfully, it returns the collection object through a **then** or **done** method.

## -examples

## -see-also