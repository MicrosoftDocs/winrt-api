---
-api-id: T:Windows.Storage.SystemProperties
-api-type: winrt class
---

<!-- Class syntax.
public class SystemProperties 
-->

# Windows.Storage.SystemProperties

## -description
Provides string values for indexing names of common [Windows file properties](http://msdn.microsoft.com/library/7532e58f-bbf2-4e36-9d81-c8e04b92cb7c) such as [System.Title](https://msdn.microsoft.com/library/windows/desktop/bb787584.aspx), and also references helper objects that provide indexing names for properties of specific file types (for example video files).

## -remarks
The scenario for using [SystemProperties](systemproperties.md) is when you are defining search indexes or other operations where you want the indexing to use the same name for a property that the system has already defined, as one of the [Windows file properties](http://msdn.microsoft.com/library/7532e58f-bbf2-4e36-9d81-c8e04b92cb7c).

Some of the [SystemProperties](systemproperties.md) properties return a string name directly. For example, [SystemProperties.Title](systemproperties_title.md) returns the string "System.Title". Some of the [SystemProperties](systemproperties.md) properties return a helper object. For example, [SystemProperties.Video](systemproperties_video.md) returns a [SystemVideoProperties](systemvideoproperties.md) object. You can then use this object's properties to get the name for a video-specific [Windows file property](http://msdn.microsoft.com/library/7532e58f-bbf2-4e36-9d81-c8e04b92cb7c), for example [SystemVideoProperties.FrameHeight](systemvideoproperties_frameheight.md) returns "System.Video.FrameHeight".

## -examples

## -see-also