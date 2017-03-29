---
-api-id: P:Windows.UI.StartScreen.SecondaryTileVisualElements.BackgroundColor
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.UI.Color BackgroundColor { get;  set; }
-->

# Windows.UI.StartScreen.SecondaryTileVisualElements.BackgroundColor

## -description
Gets or sets the secondary tile's background color.

## -property-value
The background color. Specify in #ffffff format. 

> For Windows Phone Store app, set this value to "transparent" to use the system's accent color, which is chosen by the user in **Settings**.

## -remarks
If this property is not set, its value is inherited from the background color of the parent app's tile.

## -examples
The following lines show different ways to express the color through this property.

```javascript

secondaryTileVisualElements.backgroundColor = Windows.UI.Colors.magenta;
```

```csharp

secondaryTileVisualElements.BackgroundColor = Windows.UI.Color.Magenta;
secondaryTileVisualElements.BackgroundColor = Windows.UI.Color.FromArgb(255, 255, 255, 255);
```

```cpp

secondaryTileVisualElements->BackgroundColor = Windows::UI::Colors::Magenta;
secondaryTileVisualElements->BackgroundColor = Windows::UI::ColorHelper::FromArgb(0, 255, 255, 120);
```



## -see-also
[Secondary tiles sample](http://go.microsoft.com/fwlink/p/?linkid=231487)