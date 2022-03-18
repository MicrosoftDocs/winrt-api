---
-api-id: P:Windows.Storage.FileProperties.ImageProperties.Rating
-api-type: winrt property
---

<!-- Property syntax
public uint Rating { get;  set; }
-->

# Windows.Storage.FileProperties.ImageProperties.Rating

## -description
Gets or sets the rating associated with an image file.

## -property-value
The media file rating, as a value between 0 and 99.

## -remarks
The rating property for this media file type is obtained from the [Windows file properties](/windows/desktop/properties/props), specifically from [System.Rating](/windows/desktop/properties/props-system-rating). [System.Rating](/windows/desktop/properties/props-system-rating) has a value from 0 to 99. A value of 0 indicates that the file has not been rated.

Rating info is often presented to the user as a “star” metaphor, where a star rating can be from 0 to 5 stars. This is shown as the outline of 5 star shapes, with the current rating indicated by a horizontal color bar within the 5 star shapes. For more info, see [Guidelines for the Rating control](/windows/uwp/design/controls-and-patterns/index).

For HTML UI, the [Rating](/previous-versions/windows/apps/br211895(v=win.10)) control implements a star-rating behavior, but you’ll have convert a **Rating** property value into the star-count values that the [Rating](/previous-versions/windows/apps/br211895(v=win.10)) control uses for its properties.

For XAML UI there is no default rating control in the Windows Runtime XAML vocabulary. However, several third-party control vendors have created a XAML rating control.

Here’s some suggested logic for converting the 0-99 possible value of a **Rating** property to an integer value between 0 and 5 that is suitable for a 5-star UI presentation metaphor, and for the [Rating](/previous-versions/windows/apps/br211895(v=win.10)) control: `uint starRating = rating == 0 ? 0 : (uint)Math.Round((double)rating / 25.0) + 1;
`.

## -examples

## -see-also
[Guidelines for the Rating control](/windows/uwp/design/controls-and-patterns/index)
