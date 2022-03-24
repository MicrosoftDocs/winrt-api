---
-api-id: M:Windows.UI.StartScreen.SecondaryTile.#ctor(System.String,System.String,System.String,System.String,Windows.UI.StartScreen.TileOptions,Windows.Foundation.Uri,Windows.Foundation.Uri)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public SecondaryTile(System.String tileId, System.String shortName, System.String displayName, System.String arguments, Windows.UI.StartScreen.TileOptions tileOptions, Windows.Foundation.Uri logoReference, Windows.Foundation.Uri wideLogoReference)
-->

# Windows.UI.StartScreen.SecondaryTile.SecondaryTile

## -description
> [!NOTE]
> This constructor may be altered or unavailable for releases after Windows 8.1. Instead, use [SecondaryTile.SecondaryTile(String, String, String, Uri, TileSize)](secondarytile_secondarytile_1137028492.md) and supply other tile sizes and options through [SecondaryTile.VisualElements](secondarytile_visualelements.md) method.

Creates a [SecondaryTile](secondarytile.md) object as a wide tile.

In a desktop app, before using an instance of this class in a way that displays UI, you'll need to associate the object with its owner's window handle. For more info, and code examples, see [Display WinRT UI objects that depend on CoreWindow](/windows/apps/develop/ui-input/display-ui-objects#winui-3-with-c).

> On Windows Phone 8.1, all tiles&mdash;including secondary tiles&mdash;are pinned as medium tiles, after which they can be resized by the user. This constructor provides that option of resizing to a wide tile.

## -parameters
### -param tileId
A string that will uniquely identify the tile within your app's package. Choose a unique ID that is descriptive and meaningful to your app. It is limited to 64 characters and must begin with a number or letter and be composed of the characters a-z, A-Z, 0-9, period (.), or underscore (_). If you provide the same ID as that of an existing secondary tile, the existing secondary tile will be overwritten. Can be set or retrieved through the [TileId](secondarytile_tileid.md) property.

### -param shortName
A short name to display directly on the tile if the app chooses to do so. Anything over 40 characters will be truncated. The user has the option to change this value as part of the pinning process. Can be set or retrieved through the [ShortName](secondarytile_shortname.md) property. 

> [!NOTE]
> This value is used only in Windows 8 and is deprecated in favor of the *displayName* in later versions.

### -param displayName
A name to be displayed on the tile, in the tile's tooltip, and when showing small tiles, such as on the **Apps** or search results screens. This string is equivalent to the display name given in the manifest for the main tile. It is restricted to 256 characters, but in practice should be kept short to avoid truncation. This value can be set or retrieved through the [DisplayName](secondarytile_displayname.md) property. 

> The display name is shown only on the wide secondary tile on Windows Phone 8.1.

### -param arguments
An app-defined string meaningful to the calling application. This argument string is passed back to the app when the app is activated from the secondary tile. It will be truncated after 2048 characters. Can be set or retrieved through the [Arguments](secondarytile_arguments.md) property.

### -param tileOptions
A value that specifies various options such as whether the name will be displayed on the secondary tile. Can be set or retrieved through the [TileOptions](secondarytile_tileoptions.md) property.

### -param logoReference
A reference to a medium logo image stored at a Uniform Resource Identifier (URI). Can be set or retrieved through the [Square150x150Logo](secondarytilevisualelements_square150x150logo.md) property. This value can be expressed using one of these schemes: <termdeflist><termdef><name>ms-appx:///</name>A path within the deployed app package. This path is resolved for languages and DPI plateau supported by the app.</termdef><termdef><name>ms-appdata:///local/</name>A file found in the per-user app storage.</termdef></termdeflist>

### -param wideLogoReference
A reference to a wide logo image stored at a Uniform Resource Identifier (URI). Can be set or retrieved through the [WideLogo](secondarytile_widelogo.md) property. This value can be expressed using one of these schemes: <termdeflist><termdef><name>ms-appx:///</name>A path within the deployed app package. This path is resolved for languages and DPI plateau supported by the app.</termdef><termdef><name>ms-appdata:///local/</name>A file found in the per-user app storage.</termdef></termdeflist>

## -remarks

## -examples

## -see-also