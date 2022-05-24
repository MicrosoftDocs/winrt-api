---
-api-id: M:Windows.UI.StartScreen.SecondaryTile.#ctor(System.String,System.String,System.String,Windows.Foundation.Uri,Windows.UI.StartScreen.TileSize)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public SecondaryTile(System.String tileId, System.String displayName, System.String arguments, Windows.Foundation.Uri square150x150Logo, Windows.UI.StartScreen.TileSize desiredSize)
-->

# Windows.UI.StartScreen.SecondaryTile.SecondaryTile

## -description
Creates a [SecondaryTile](secondarytile.md) object that includes all of the mandatory properties required to create a medium tile.

In a desktop app, before using an instance of this class in a way that displays UI, you'll need to associate the object with its owner's window handle. For more info, and code examples, see [Display WinRT UI objects that depend on CoreWindow](/windows/apps/develop/ui-input/display-ui-objects#winui-3-with-c).

## -parameters
### -param tileId
A string that will uniquely identify the tile within your app's package. Choose a unique ID that is descriptive and meaningful to your app. It is limited to 64 characters and must begin with a number or letter and be composed of the characters a-z, A-Z, 0-9, period (.), or underscore (_). If you provide the same ID as that of an existing secondary tile, the existing secondary tile will be overwritten. Can be set or retrieved through the [TileId](secondarytile_tileid.md) property.

### -param displayName
A name to be displayed on the tile, in the tile's tooltip, and when showing small tiles, such as on the **Apps** or search results screens. This string is equivalent to the display name given in the manifest for the main tile. It is restricted to 256 characters, but in practice should be kept short to avoid truncation. This value can be set or retrieved through the [DisplayName](secondarytile_displayname.md) property. 

> The display name is shown only on the wide secondary tile on Windows Phone 8.1.

### -param arguments
An app-defined string meaningful to the calling application. This argument string is passed back to the app when the app is activated from the secondary tile. It will be truncated after 2048 characters. Can be set or retrieved through the [Arguments](secondarytile_arguments.md) property. 

> [!NOTE]
> This parameter must be URL-encoded for Windows Phone Silverlight 8.1 apps. All other app types can use their own structure.

### -param square150x150Logo
A reference to a medium logo image stored at a Uniform Resource Identifier (URI). Can be set or retrieved through the [SecondaryTileVisualElements.Square150x150Logo](secondarytilevisualelements_square150x150logo.md) property. This value can be expressed using one of these schemes: <termdeflist><termdef><name>ms-appx:///</name>A path within the deployed app package. This path is resolved for languages and DPI plateau supported by the app.</termdef><termdef><name>ms-appdata:///local/</name>A file found in the per-user app storage.</termdef></termdeflist>

### -param desiredSize
The size of tile to pin. This value must be **Default** (which provides Windows 8 behavior), **Square150x150**, or **Wide310x150**. Any other [TileSize](tilesize.md) value causes an exception to be thrown during runtime. 

> The *desiredSize* parameter is ignored on Windows Phone 8.1. On the phone, all tiles— including secondary tiles— are pinned as medium tiles, after which they can be resized by the user.

## -remarks

## -examples

## -see-also
