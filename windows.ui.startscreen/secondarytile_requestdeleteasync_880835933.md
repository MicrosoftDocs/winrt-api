---
-api-id: M:Windows.UI.StartScreen.SecondaryTile.RequestDeleteAsync
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> RequestDeleteAsync()
-->

# Windows.UI.StartScreen.SecondaryTile.RequestDeleteAsync

## -description
Displays the **Unpin from Start**  flyout. This flyout lets the user confirm removal of the secondary tile.

## -returns
An object that provides information concerning the asynchronous delete operation.

## -remarks

## -examples
The following example demonstrates how to delete (unpin) a secondary tile. Note that this example assumes that the tile exists. To determine whether the tile is pinned before you call [RequestDeleteAsync](secondarytile_requestdeleteasync_880835933.md), see the [Exists](secondarytile_exists.md) method.

```javascript

// Specify the tile to be deleted, using the ID that it was given when it was originally created.
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



## -see-also