---
-api-id: P:Windows.UI.StartScreen.SecondaryTile.BackgroundColor
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.UI.Color BackgroundColor { get;  set; }
-->

# Windows.UI.StartScreen.SecondaryTile.BackgroundColor

## -description
> [!NOTE]
> BackgroundColor may be altered or unavailable for releases after Windows 8.1. Instead, use [SecondaryTileVisualElements.BackgroundColor](secondarytilevisualelements_backgroundcolor.md).

Gets or sets the tile's background color.

## -property-value
The background color.

## -remarks
If this property is not set, its value is inherited from the background color of the parent app's tile.

## -examples
The following lines show different ways to express the color through this property.

```csharp
secondaryTile.BackgroundColor = Windows.UI.Color.Magenta;
secondaryTile.BackgroundColor = Windows.UI.Color.FromArgb(255, 255, 255, 255);
```

```cppwinrt
secondaryTile.BackgroundColor(Windows::UI::Colors::Magenta());
secondaryTile.BackgroundColor(Windows::UI::ColorHelper::FromArgb(0, 255, 255, 120));
```

```cppcx
secondaryTile->BackgroundColor = Windows::UI::Colors::Magenta;
secondaryTile->BackgroundColor = Windows::UI::ColorHelper::FromArgb(0, 255, 255, 120);
```

## -see-also
