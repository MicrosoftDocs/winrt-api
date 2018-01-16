---
-api-id: M:Windows.UI.StartScreen.SecondaryTile.RequestCreateAsync
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> RequestCreateAsync()
-->

# Windows.UI.StartScreen.SecondaryTile.RequestCreateAsync

## -description
Displays the **Pin to Start**  flyout, through which the user can confirm that they want to create the secondary tile, which in turn creates the tile. Overloads of this method let you specify the on-screen location of the flyout.

> [!NOTE]
> It is a best practice to display the **Pin to Start**  flyout near the button that invoked the request to create the tile. Therefore, we recommend that you use the [RequestCreateAsync(Point)](secondarytile_requestcreateasync_318145127.md) form of this method overload.

> On Windows Phone 8.1, the secondary tile is created through this call without showing the user a flyout, prompting them for confirmation, or allowing them to choose a tile size or title text. Note that when using the [RequestCreateAsync](secondarytile_requestcreateasync.md) method to pin a secondary tile in Windows Phone 8.x app, the app is suspended and the user is taken to the Start screen. This same API call on a PC does not suspend the program. Therefore, be aware that any code called after [RequestCreateAsync](secondarytile_requestcreateasync.md) is not guaranteed to be run before the app is suspended. To avoid this potential issue you should use the OnSuspended event of your app to run any code, such as updating the pinned tile, that should be run before the app suspends. To see an example of this pattern, download and run the [Tile update on suspend sample](http://go.microsoft.com/fwlink/p/?LinkId=394144).

## -returns
An object used to launch the asynchronous create operation as well as to retrieve information about it.

## -remarks
After a secondary tile is created, you must provide the following properties before it is displayed: 
+ [tileId](secondarytile_tileid.md)
+ [displayName](secondarytile_displayname.md)
+ [arguments](secondarytile_arguments.md)
+ [SecondaryTileVisualElements.Square150x150Logo](secondarytilevisualelements_square150x150logo.md)


This method returns an asynchronous **Boolean** value through its [IAsyncOperation](../windows.foundation/iasyncoperation_1.md) object as shown here. A value of **true** indicates that the secondary tile was created and pinned to the Start screen.
  
```JavaScript  
secondaryTile.requestCreateAsync().then( function (isPinned) { } );
```

```csharp
async void showTileCreateRequest( SecondaryTile tile )  
{      
    bool isPinned = await tile.requestCreateAsync();  
}
```



## -examples
The following example creates and pins a previously defined [SecondaryTile](secondarytile.md) object "tile" to the Start screen.

```javascript

tile.requestCreateAsync().then(function (isCreated) {
    if (isCreated) {
        // Secondary tile successfully pinned.
    } else {
        // Secondary tile not pinned.
    }
});
```



## -see-also
