---
-api-id: M:Windows.UI.StartScreen.SecondaryTile.RequestDeleteForSelectionAsync(Windows.Foundation.Rect)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> RequestDeleteForSelectionAsync(Windows.Foundation.Rect selection)
-->

# Windows.UI.StartScreen.SecondaryTile.RequestDeleteForSelectionAsync

## -description
Displays the **Unpin from Start**  flyout above a specified area. This flyout lets the user confirm removal of the secondary tile.

## -parameters
### -param selection
The area that the secondary tile is displayed directly above.

## -returns
An object that provides information concerning the asynchronous delete operation.

## -remarks
The only property that must be set on the tile before calling this method is [tileId](secondarytile_tileid.md). If [tileId](secondarytile_tileid.md) is not set, the call to this method raises an exception.

## -examples

## -see-also
[RequestDeleteForSelectionAsync(Rect, Placement)](secondarytile_requestdeleteforselectionasync_1725235400.md), [Secondary tiles sample](http://go.microsoft.com/fwlink/p/?linkid=231487)