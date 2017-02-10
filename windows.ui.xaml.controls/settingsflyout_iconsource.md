---
-api-id: P:Windows.UI.Xaml.Controls.SettingsFlyout.IconSource
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.ImageSource IconSource { get;  set; }
-->

# Windows.UI.Xaml.Controls.SettingsFlyout.IconSource

## -description
Gets or sets the icon image displayed in the [SettingsFlyout](settingsflyout.md) header.

## -xaml-syntax
```xaml
<SettingsFlyout IconSource="uri"/>
```


## -xaml-values
<dl><dt>uri</dt><dd>uriThe location of the image source file. In XAML syntax, you can specify what appears to be a relative that is relative to a base . The base is interpreted based on the location of the XAML file that loads it, and uses the ms-appx: scheme implicitly. For more info see Remarks.</dd>
</dl>
## -property-value
The icon image displayed in the [SettingsFlyout](settingsflyout.md) header area, typically to the right of the [Title](settingsflyout_title.md). The default is **null**, which results in no displayed image.

## -remarks
> [!NOTE]
> Even though the default property value is **null**, the Microsoft Visual Studio Settings Flyout item template sets the [IconSource](settingsflyout_iconsource.md) to your app’s small logo (`IconSource="Assets/SmallLogo.png"`).

The [IconSource](settingsflyout_iconsource.md) property is typically set in XAML to take advantage of the built-in conversion from string.

If you do set the [IconSource](settingsflyout_iconsource.md) property in code, you can use a [BitmapImage](../windows.ui.xaml.media.imaging/bitmapimage.md) object, constructed with the Uniform Resource Identifier (URI) that describes the path to a valid image source file. You can also initialize a [BitmapSource](../windows.ui.xaml.media.imaging/bitmapsource.md) with a stream, perhaps a stream from a storage file, but that's not typical for a [SettingsFlyout](settingsflyout.md) UI scenario.

### Setting **IconSource** in XAML

If you set the [IconSource](settingsflyout_iconsource.md) property as an attribute in XAML, you are setting the [IconSource](settingsflyout_iconsource.md) property using a Uniform Resource Identifier (URI). This behavior relies on underlying type conversion that processes the string as a Uniform Resource Identifier (URI), and calls the equivalent of the [BitmapImage(Uri)](../windows.ui.xaml.media.imaging/bitmapimage_bitmapimage_843413386.md) constructor. The XAML parser interprets any strings that represent a relative Uniform Resource Identifier (URI), using the base Uniform Resource Identifier (URI) of the XAML page that is being parsed. For example, if you specify a value "Images/myimage.png" in XAML, that string is interpreted as a relative path suffix that is appended to the base Uniform Resource Identifier (URI) location within the app package where the XAML page itself exists.

```xaml
<SettingsFlyout Width="346" IconSource="Images/myimage.png" />
```

A property element syntax in XAML is also possible, specifying a [BitmapImage](../windows.ui.xaml.media.imaging/bitmapimage.md) object element with valid source as the property value.

## -examples

## -see-also
[Image.Source](image_source.md)