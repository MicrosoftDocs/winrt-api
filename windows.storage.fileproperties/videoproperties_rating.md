---
-api-id: P:Windows.Storage.FileProperties.VideoProperties.Rating
-api-type: winrt property
---

<!-- Property syntax
public uint Rating { get;  set; }
-->

# Windows.Storage.FileProperties.VideoProperties.Rating

## -description
Gets or sets the rating associated with a video file.

## -property-value
The media file rating, as a value between 0 and 99.

## -remarks
The rating property for this media file type is obtained from the [Windows file properties](https://msdn.microsoft.com/library/7532e58f-bbf2-4e36-9d81-c8e04b92cb7c), specifically from [System.Rating](https://msdn.microsoft.com/library/windows/desktop/bb787554.aspx). [System.Rating](https://msdn.microsoft.com/library/windows/desktop/bb787554.aspx) has a value from 0 to 99. A value of 0 indicates that the file has not been rated.

Rating info is often presented to the user as a “star” metaphor, where a star rating can be from 0 to 5 stars. This is shown as the outline of 5 star shapes, with the current rating indicated by a horizontal color bar within the 5 star shapes. For more info, see [Guidelines for the Rating control](https://msdn.microsoft.com/library/7ef0eeeb-c097-4508-a295-2eba3f79cafd).

For HTML UI, the [Rating](https://msdn.microsoft.com/library/5f0a82ee-7a91-4b49-851c-580510000c7a) control implements a star-rating behavior, but you’ll have convert a **Rating** property value into the star-count values that the [Rating](https://msdn.microsoft.com/library/5f0a82ee-7a91-4b49-851c-580510000c7a) control uses for its properties.

For XAML UI there is no default rating control in the Windows Runtime XAML vocabulary. However, several third-party control vendors have created a XAML rating control.

Here’s some suggested logic for converting the 0-99 possible value of a **Rating** property to an integer value between 0 and 5 that is suitable for a 5-star UI presentation metaphor, and for the [Rating](https://msdn.microsoft.com/library/5f0a82ee-7a91-4b49-851c-580510000c7a) control: `uint starRating = rating == 0 ? 0 : (uint)Math.Round((double)rating / 25.0) + 1;
`.

## -examples

## -see-also
[Guidelines for the Rating control](https://msdn.microsoft.com/library/7ef0eeeb-c097-4508-a295-2eba3f79cafd)
