---
-api-id: M:Windows.UI.StartScreen.SecondaryTile.#ctor
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public SecondaryTile()
-->

# Windows.UI.StartScreen.SecondaryTile.SecondaryTile

## -description
Creates a [SecondaryTile](secondarytile.md) object. The caller must then set any mandatory properties through the object before attempting to pin, update, or delete the tile.

## -remarks
Mandatory tile properties, such as the display name, must be set through calls to other methods of this class before the tile can be activated.

To use this object from a desktop app, create the object, and then use [the IInitializeWithWindow::Initialize method](https://docs.microsoft.com/en-us/windows/desktop/api/shobjidl_core/nf-shobjidl_core-iinitializewithwindow-initialize) to associate the object with a window handle.

## -examples

## -see-also