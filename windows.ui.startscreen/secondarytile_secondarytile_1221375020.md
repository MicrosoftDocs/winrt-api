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

In a desktop app, before using an instance of this class in a way that displays UI, you'll need to associate the object with its owner's window handle. For more info, and code examples, see [Display WinRT UI objects that depend on CoreWindow](/windows/apps/develop/ui-input/display-ui-objects#winui-3-with-c).

## -remarks
Mandatory tile properties, such as the display name, must be set through calls to other methods of this class before the tile can be activated.

## -examples

## -see-also