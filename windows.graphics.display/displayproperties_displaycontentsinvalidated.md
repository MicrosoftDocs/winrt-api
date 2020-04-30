---
-api-id: E:Windows.Graphics.Display.DisplayProperties.DisplayContentsInvalidated
-api-type: winrt event
---

<!-- Event syntax
static public event Windows.Graphics.Display.DisplayPropertiesEventHandler DisplayContentsInvalidated
-->

# Windows.Graphics.Display.DisplayProperties.DisplayContentsInvalidated

## -description
> [!NOTE]
> [DisplayProperties](displayproperties.md) may be altered or unavailable for releases after Windows 8.1. Instead, use [DisplayInformation](displayinformation.md).

Occurs when the display requires redrawing.

## -remarks

## -examples

```cppwinrt
DisplayProperties::DisplayContentsInvalidated({ this, &ShapesPuzzle::OnDisplayContentsInvalidated });
```

```cppcx
DisplayProperties::DisplayContentsInvalidated +=
    ref new DisplayPropertiesEventHandler(this, &ShapesPuzzle::OnDisplayContentsInvalidated);
```

## -see-also
