---
-api-id: M:Windows.Media.Editing.MediaClip.CreateFromColor(Windows.UI.Color,Windows.Foundation.TimeSpan)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Media.Editing.MediaClip CreateFromColor(Windows.UI.Color color, Windows.Foundation.TimeSpan originalDuration)
-->

# Windows.Media.Editing.MediaClip.CreateFromColor

## -description
Creates a solid color video clip that displays a single color for a specified length of time. Solid color video clips are typically used to create an explicit gap between video segments.

## -parameters
### -param color
The color to display in the video clip.

### -param originalDuration
How long to display the color in the video clip.

## -returns
A new media clip object containing the color-based video clip.

## -remarks

Note that the created clip does not use the alpha component of the specified color.

## -examples

## -see-also
