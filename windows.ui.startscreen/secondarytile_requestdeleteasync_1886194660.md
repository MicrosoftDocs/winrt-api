---
-api-id: M:Windows.UI.StartScreen.SecondaryTile.RequestDeleteAsync(Windows.Foundation.Point)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> RequestDeleteAsync(Windows.Foundation.Point invocationPoint)
-->

# Windows.UI.StartScreen.SecondaryTile.RequestDeleteAsync

## -description
Displays the **Unpin from Start** flyout at a specified point. This flyout lets the user confirm removal of the secondary tile.

## -parameters
### -param invocationPoint
The point used as the lower-right corner of the **Pin to Start**  flyout.

## -returns
An object that provides information concerning the asynchronous delete operation.

## -remarks
The only property that must be set on the tile before calling this method is [TileId](secondarytile_tileid.md). If [TileId](secondarytile_tileid.md) is not set, the call to this method raises an exception.

This method returns an asynchronous Boolean value through its [IAsyncOperation.GetResults](../windows.foundation/iasyncoperation_1.md) method as shown here.

```csharp
void async showTileCreateRequest( SecondaryTile tile, Point pt)  
{
    bool isDeleted = await tile.requestCreateAsync( pt );  
}
```

## -examples

## -see-also