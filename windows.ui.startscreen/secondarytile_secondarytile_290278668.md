---
-api-id: M:Windows.UI.StartScreen.SecondaryTile.#ctor(System.String)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public SecondaryTile(System.String tileId)
-->

# Windows.UI.StartScreen.SecondaryTile.SecondaryTile

## -description
Creates a [SecondaryTile](secondarytile.md) object with a specific ID. This form of the constructor should be used to create a secondary tile object to perform a tile update or deletion.

## -parameters
### -param tileId
A string that will uniquely identify the tile within your app. Choose a unique ID that is descriptive and meaningful to your app. If you provide the same ID as that of an existing secondary tile, the existing secondary tile will be overwritten.

## -remarks
The unique ID that you use to create this tile can be used later update or delete it.

Other mandatory tile properties, such as the display name, must be set through calls to other methods of this class before the tile can be activated.

To use this object from a desktop app, create the object, and then use [the IInitializeWithWindow::Initialize method](/en-us/windows/desktop/api/shobjidl_core/nf-shobjidl_core-iinitializewithwindow-initialize) to associate the object with a window handle.

## -examples

## -see-also