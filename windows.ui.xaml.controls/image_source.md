---
-api-id: P:Windows.UI.Xaml.Controls.Image.Source
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.ImageSource Source { get;  set; }
-->

# Windows.UI.Xaml.Controls.Image.Source

## -description
Gets or sets the source for the image.



## -xaml-syntax
```xaml
<Image Source="uri"/>
```

## -xaml-values
<dl><dt>uri</dt><dd>uriThe location of the image source file. In XAML syntax, you can specify what appears to be a relative that is relative to a base . The base is interpreted based on the location of the XAML file that loads it, and uses the ms-appx: scheme implicitly. For more info see Remarks.</dd>
</dl>

## -property-value
An object that represents the image source file for the drawn image. Typically you set this with a [BitmapImage](../windows.ui.xaml.media.imaging/bitmapimage.md) object, constructed with the Uniform Resource Identifier (URI) that describes the path to a valid image source file. Or, you can initialize a [BitmapSource](../windows.ui.xaml.media.imaging/bitmapsource.md) with a stream, perhaps a stream from a storage file.

## -remarks
Setting the Source property is inherently an asynchronous action. Because it's a property, there isn't an awaitable syntax, but for most scenarios you don't need to interact with the asynchronous aspects of image source file loading. The framework will wait for the image source to be returned, and will rerun layout when the image source file becomes available.

Setting the source to a Uniform Resource Identifier (URI) value that can't be resolved to a valid image source file does not throw an exception. Instead, it fires an [ImageFailed](image_imagefailed.md) event. Decoding failures also fire [ImageFailed](image_imagefailed.md). You can write an [ImageFailed](image_imagefailed.md) handler and attach it to the [Image](image.md) object to detect this, and possibly use the [ErrorMessage](../windows.ui.xaml/exceptionroutedeventargs_errormessage.md) in event data to determine the nature of the failure. Also, if you want to verify that an image source file was loaded correctly, you can handle the [ImageOpened](image_imageopened.md) event on the [Image](image.md) element.

### Setting Source in XAML

You can set the Source property as an attribute in XAML. In this case, you're setting the Source attribute value as a Uniform Resource Identifier (URI) string that describes the location of the source image file. This behavior relies on underlying type conversion that processes the string as a Uniform Resource Identifier (URI), and calls the equivalent of the [BitmapImage(Uri)](../windows.ui.xaml.media.imaging/bitmapimage_bitmapimage_843413386.md) constructor. Setting the Source property using a Uniform Resource Identifier (URI) string is a shortcut enabled by XAML. Note that the Uniform Resource Identifier (URI) here appears to be a relative Uniform Resource Identifier (URI); supporting partial Uniform Resource Identifier (URI) is another XAML shortcut.

```xaml
<Image Width="200" Source="Images/myImage.png"/>
```

The XAML parser interprets any strings that represent a relative Uniform Resource Identifier (URI) using the base Uniform Resource Identifier (URI) of the XAML page that is being parsed. For example, if you specify a value "Images/myImage.png" in XAML, that string is interpreted as a relative path suffix that is appended to the base Uniform Resource Identifier (URI) location within the app package where the XAML page itself exists. If the previous [Image](image.md) element is added to a page that's in the root of the app package, the Uniform Resource Identifier (URI) is interpreted as ms-appx:///Images/myImage.png. If the [Image](image.md) is added to a page that's in a Pages folder in the app, the Uniform Resource Identifier (URI) is interpreted as ms-appx:///Pages/Images/myImage.png.

If the source image is not part of the app package, you must use an absolute Uniform Resource Identifier (URI) to set the Source property in XAML. For more info, see [How to load file resources](/previous-versions/windows/apps/hh965322(v=win.10)), and examples later in this document.

A property element syntax in XAML is also possible, specifying a [BitmapImage](../windows.ui.xaml.media.imaging/bitmapimage.md) object element with valid source as the property value.

### Setting Source in code

To set the Image.Source property in code requires an instance of [BitmapImage](../windows.ui.xaml.media.imaging/bitmapimage.md) (or [BitmapSource](../windows.ui.xaml.media.imaging/bitmapsource.md)), which you also must construct. If your image source is a stream, use the async [SetSourceAsync](../windows.ui.xaml.media.imaging/bitmapsource_setsourceasync_1118221574.md) method of [BitmapImage](../windows.ui.xaml.media.imaging/bitmapimage.md) to define the image information from the stream.

If your image source is a file referenced by Uniform Resource Identifier (URI), set the [BitmapImage.UriSource](../windows.ui.xaml.media.imaging/bitmapimage_urisource.md) property, or use the [BitmapImage](../windows.ui.xaml.media.imaging/bitmapimage_bitmapimage_843413386.md) constructor that takes a Uniform Resource Identifier (URI) parameter. The Windows Runtime enforces that a Uniform Resource Identifier (URI) must be absolute; you can't use relative Uniform Resource Identifier (URI) in Windows Runtime code. If you are using a .NET Framework  [System.Uri](/dotnet/api/system.uri?view=dotnet-uwp-10.0&preserve-view=true) value, and you use a signature that requires a [UriKind](/dotnet/api/system.urikind?view=dotnet-uwp-10.0&preserve-view=true) value, make sure to specify **Absolute**.

When you reference local content, you must include the **ms-appx:** scheme in the absolute Uniform Resource Identifier (URI) that you use as the [BitmapImage.UriSource](../windows.ui.xaml.media.imaging/bitmapimage_urisource.md). In code, you don't get the processing shortcuts for combining relative Uniform Resource Identifier (URI) parts and the **ms-appx:** scheme that happens automatically if you specify Source as a XAML attribute. Instead you must explicitly construct an absolute Uniform Resource Identifier (URI) with the appropriate scheme.

Here's how to set the source to an image from the app package.

```csharp
Image img = new Image();
BitmapImage bitmapImage = new BitmapImage();
Uri uri = new Uri("ms-appx:///Assets/Logo.png");
bitmapImage.UriSource = uri;
img.Source = bitmapImage;

// OR

Image img = new Image();
img.Source = new BitmapImage(new Uri("ms-appx:///Assets/Logo.png"));
```

```cppwinrt
Windows::UI::Xaml::Controls::Image img;
Windows::UI::Xaml::Media::Imaging::BitmapImage bitmapImage;
Windows::Foundation::Uri uri{ L"ms-appx:///Assets/LockScreenLogo.png" };
bitmapImage.UriSource(uri);
img.Source(bitmapImage);

// OR

Windows::UI::Xaml::Controls::Image img;
img.Source(Windows::UI::Xaml::Media::Imaging::BitmapImage{ Windows::Foundation::Uri{ L"ms-appx:///Assets/LockScreenLogo.png" } });
```

```cppcx
auto img = ref new Image();
auto bitmapImage = ref new Windows::UI::Xaml::Media::Imaging::BitmapImage();
auto uri = ref new Windows::Foundation::Uri("ms-appx:///Assets/Logo.png");
bitmapImage->UriSource = uri;
img->Source = bitmapImage;

// OR

auto img = ref new Image();
img->Source = ref new BitmapImage(ref new Windows::Foundation::Uri("ms-appx:///Assets/Logo.png"));
```

If you need to ensure that the [Image](image.md) control is ready before trying to use it in code, handle the [Loaded](../windows.ui.xaml/frameworkelement_loaded.md) event, and set the Source property in the event handler.

> [!NOTE]
> The [FrameworkElement.Loaded](../windows.ui.xaml/frameworkelement_loaded.md) event occurs when the [Image](image.md) control is loaded into the XAML page. The [ImageOpened](image_imageopened.md) event occurs when the image file is opened in the [Image](image.md) control.

Here's an example of setting Image.Source in the handler for the [Loaded](../windows.ui.xaml/frameworkelement_loaded.md) event. In this example, the [Image](image.md) object was created in XAML but doesn't have a source or any other property values; instead these values are provided at run-time when the [Image](image.md) is loaded from XAML.

```xaml
<Image Loaded="Image_Loaded"/>
```

```csharp
void Image_Loaded(object sender, RoutedEventArgs e)
{
    Image img = sender as Image;
    if (img != null)
    {
        BitmapImage bitmapImage = new BitmapImage();
        img.Width = bitmapImage.DecodePixelWidth = 280;
        bitmapImage.UriSource = new Uri("ms-appx:///Assets/Logo.png");
        img.Source = bitmapImage;
    }
}
```

```cppwinrt
void MainPage::Image_Loaded(winrt::Windows::Foundation::IInspectable const& sender, winrt::Windows::UI::Xaml::RoutedEventArgs const& /* e */)
{
    auto img{ sender.as<Windows::UI::Xaml::Controls::Image>() }; // throws if QI fails, so no need for null-check afterwards.
    Windows::UI::Xaml::Media::Imaging::BitmapImage bitmapImage;
    img.Width(280);
    bitmapImage.DecodePixelWidth(280);
    bitmapImage.UriSource(Windows::Foundation::Uri{ L"ms-appx:///Assets/LockScreenLogo.png" });
    img.Source(bitmapImage);
}
```

```cppcx
void App1::MainPage::Image_Loaded(Platform::Object^ sender, Windows::UI::Xaml::RoutedEventArgs^ e)
{
 auto img = dynamic_cast<Image^>(sender);
 if (img != nullptr)
 {
  auto bitmapImage = ref new BitmapImage();
  img->Width = 280; bitmapImage->DecodePixelWidth = 280;
  bitmapImage->UriSource = ref new Uri("ms-appx:///Assets/Logo.png");
  img->Source = bitmapImage;
 }
}
```

You can handle the [ImageOpened](image_imageopened.md) event if there are any timing issues with retrieving or decoding the image source, where you might need alternate content to display until the image source is available. See [XAML images sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/XAML%20images%20sample) for example code.

### Using a relative URI in code

We saw previously that the XAML parser interprets a relative Uniform Resource Identifier (URI) using the base Uniform Resource Identifier (URI) of the XAML page that is being parsed. To achieve the same result in code, you can construct a **Uri** using one of the constructors that creates a Uniform Resource Identifier (URI) by combining an absolute base and then a relative path within that location. For the first parameter, call [BaseUri](../windows.ui.xaml/frameworkelement_baseuri.md) on [Page](page.md) where the [Image](image.md) is loaded. (You can also call [BaseUri](../windows.ui.xaml/frameworkelement_baseuri.md) on the [Image](image.md) instance where you are setting the source, or another element on the page. See the Caution below.) This creates a Uniform Resource Identifier (URI) with the **ms-appx:** scheme and adds the path that is part of the XAML page's location. For the second parameter, pass the relative Uniform Resource Identifier (URI) string that describes the source image location.

In C# or Microsoft Visual Basic, the **Uri** type is projected as [System.Uri](/dotnet/api/system.uri?view=dotnet-uwp-10.0&preserve-view=true), so use the [System.Uri(Uri, String)](/dotnet/api/system.uri?view=dotnet-uwp-10.0&preserve-view=true) constructor that takes a string as the second parameter. In Visual C++ component extensions (C++/CX) use [Uri(String,String)](../windows.foundation/uri_uri_290278668.md).

```xaml
<Image x:Name="capturedPhoto"/>
```

```csharp
BitmapImage bitmapImage = new BitmapImage();
// Call BaseUri on the root Page element and combine it with a relative path
// to consruct an absolute URI.
bitmapImage.UriSource = new Uri(this.BaseUri, "Assets/placeholder.png");
capturedPhoto.Source = bitmapImage;
```

```cppwinrt
auto bitmapImage = winrt::Windows::UI::Xaml::Media::Imaging::BitmapImage();
// Call BaseUri on the root Page element and combine it with a relative path
// to consruct an absolute URI.
bitmapImage.UriSource(winrt::Windows::Foundation::Uri(BaseUri().AbsoluteUri(), L"Assets/placeholder.png"));
capturedPhoto.Source(bitmapImage);
```

```cppcx
auto bitmapImage = ref new Windows::UI::Xaml::Media::Imaging::BitmapImage();
// Call BaseUri on the root Page element and combine it with a relative path
// to consruct an absolute URI.
bitmapImage->UriSource = ref new Windows::Foundation::Uri(BaseUri->AbsoluteUri, "Assets/placeholder.png");
capturedPhoto->Source = bitmapImage;
```

> [!NOTE]
> If you instantiate a new [Image](image.md) in code, the [BaseUri](../windows.ui.xaml/frameworkelement_baseuri.md) property is **null** until the [Image](image.md) is added to the visual tree of the a page. For example, the following code throws an **ArgumentNull** exception. To avoid the exception, add the [Image](image.md) to the visual tree before setting the Source property.

This example throws an exception because it calls [BaseUri](../windows.ui.xaml/frameworkelement_baseuri.md) on the [Image](image.md) before the [Image](image.md) is added to the page. It's assumed that 'stackPanel1' is a [StackPanel](stackpanel.md) element declared in XAML.

```csharp
Image img = new Image();
BitmapImage bitmapImage = new BitmapImage();

// AN EXCEPTION IS THROWN BECAUSE img.BaseUri IS NULL AT THIS POINT.
Uri uri = new Uri(img.BaseUri, "Assets/Logo.png");

bitmapImage.UriSource = uri;
img.Source = bitmapImage;
stackPanel1.Children.Add(img);
```

```cppwinrt
Image img;
BitmapImage bitmapImage;

// AN EXCEPTION IS THROWN BECAUSE img.BaseUri IS NULL AT THIS POINT.
Uri uri(img.BaseUri(), L"Assets/Logo.png");

bitmapImage.UriSource(uri);
img.Source(bitmapImage);
stackPanel1.Children().Add(img);
```

```cppcx
auto img = ref new Image();
auto bitmapImage = ref new Windows::UI::Xaml::Media::Imaging::BitmapImage();

// AN EXCEPTION IS THROWN BECAUSE img->BaseUri IS NULL AT THIS POINT.
auto uri = ref new Windows::Foundation::Uri(img->BaseUri->AbsoluteUri, "Assets/Logo.png");

bitmapImage->UriSource = uri;
img->Source = bitmapImage;
stackPanel1->Children->Append(img);
```

To avoid this error, you can call [BaseUri](../windows.ui.xaml/frameworkelement_baseuri.md) on the [Page](page.md) itself, as shown previously, or add the [Image](image.md) to the page before calling [BaseUri](../windows.ui.xaml/frameworkelement_baseuri.md), as shown here.

In this example, the [Image](image.md) is added to the page before the call to [BaseUri](../windows.ui.xaml/frameworkelement_baseuri.md), so [BaseUri](../windows.ui.xaml/frameworkelement_baseuri.md) is not **null**. It's assumed that 'stackPanel1' is a [StackPanel](stackpanel.md) element declared in XAML.

```csharp

Image img = new Image();
// Add the image to the page.
stackPanel1.Children.Add(img);

BitmapImage bitmapImage = new BitmapImage();
// img.BaseUri in not null because img has been added to the page.
Uri uri = new Uri(img.BaseUri, "Assets/Logo.png");
bitmapImage.UriSource = uri;
img.Source = bitmapImage;
```

```cppwinrt

Image img;
// Add the image to the page.
stackPanel1.Children().Add(img);

BitmapImage bitmapImage;
// img.BaseUri in not null because img has been added to the page.
Uri uri(img.BaseUri(), L"Assets/Logo.png");
bitmapImage.UriSource(uri);
img.Source(bitmapImage);
```

```cppcx
auto img = ref new Image();
// Add the image to the page.
stackPanel1->Children->Append(img);

auto bitmapImage = ref new Windows::UI::Xaml::Media::Imaging::BitmapImage();
// img->BaseUri in not null because img has been added to the page.
auto uri = ref new Windows::Foundation::Uri(img->BaseUri->AbsoluteUri, "Assets/Logo.png");
bitmapImage->UriSource = uri;
img->Source = bitmapImage;
```

### Using files from a network

To use a file from a network location as an image source, use the **http:** or **https:** schemes, as shown here. Specify the absolute Uniform Resource Identifier (URI). For more info, see [How to load file resources](/previous-versions/windows/apps/hh965322(v=win.10)).

```xaml
<Image Source="http://www.contoso.com/images/logo.png"/>
```

```csharp
Image img = new Image();
img.Source = new BitmapImage(new Uri("http://www.contoso.com/images/logo.png"));
```

```cppwinrt
Image img;
img.Source(BitmapImage(Uri(L"http://www.contoso.com/images/logo.png")));
```

```cppcx
auto img = ref new Image();
img->Source = ref new BitmapImage(ref new Windows::Foundation::Uri("http://www.contoso.com/images/logo.png"));
```

### Using files from local storage

To use files that are placed in your app's local storage as an image source , use the **ms-appdata:** scheme, as shown here. Specify the absolute Uniform Resource Identifier (URI). For more info, see [How to load file resources](/previous-versions/windows/apps/hh965322(v=win.10)).

```xaml
<!-- Access an image file stored in the local folder -->
<Image Source="ms-appdata:///local/images/logo.png"/>

<!-- Access an image file stored in the roaming folder -->
<Image Source="ms-appdata:///roaming/images/logo.png"/>

<!-- Access an image file stored in the temp folder -->
<Image Source="ms-appdata:///temp/images/logo.png"/>
```

```csharp
var uri = new System.Uri("ms-appdata:///local/images/logo.png");
var file = await Windows.Storage.StorageFile.GetFileFromApplicationUriAsync(uri);

Image img = new Image();
img.Source = file;
```

<!--Need to do C++ snippet. Can't find one anywhere on the dev center for GetFileFromApplicationUriAsync.-->

<!--<snippet type="code" devlang="cpp"><![CDATA[
auto uri = ref new Windows::Foundation::Uri("ms-appdata:///local/images/logo.png");
auto file = Windows::Storage::StorageFile->GetFileFromApplicationUriAsync(uri);

auto img = ref new Image();
img->Source = file;]]></snippet>-->

### Using a stream source to show images from the Pictures library

A typical use of [Image](image.md) elements in an app is to show pictures from the user's Pictures library. These pictures might be accessed programmatically or through a [FileOpenPicker](../windows.storage.pickers/fileopenpicker.md). In either case, the [StorageFile](../windows.storage/storagefile.md) object you get can be opened as a stream, but doesn't provide a Uniform Resource Identifier (URI) reference to the image file. To use a stream as an image source, you must write code that sets your [Image](image.md) instance to use the stream. This can't be done in XAML alone.

To display an individual image, use the [StorageFile](../windows.storage/storagefile.md) objects from enumerating the library and call [OpenAsync](../windows.storage/storagefile_openasync_1542217918.md) to obtain a stream. Use this stream to set the image source, by creating a new [BitmapImage](../windows.ui.xaml.media.imaging/bitmapimage.md), then calling [SetSourceAsync](../windows.ui.xaml.media.imaging/bitmapsource_setsourceasync_1118221574.md) and passing the stream to use as the *streamSource* parameter.

This example shows how to use a [FileOpenPicker](../windows.storage.pickers/fileopenpicker.md) to access an image file from the Pictures library and set it as the Source of an [Image](image.md) control. The code is already awaitable because it's waiting for the user to choose a file and it only runs after that happens. The stream to use comes from [StorageFile.OpenAsync](../windows.storage/storagefile_openasync_1542217918.md) after a [StorageFile](../windows.storage/storagefile.md) instance is returned from the async picker actions. For more info on using file pickers, see [Open files and folders with a picker](/windows/uwp/files/quickstart-using-file-and-folder-pickers).

```xaml
<Button Content="Get photo" Click="GetPhotoButton_Click"/>

<Image x:Name="image1" Width="300"/>
```

```csharp
private async void GetPhotoButton_Click(object sender, RoutedEventArgs e)
{
    // Set up the file picker.
    Windows.Storage.Pickers.FileOpenPicker openPicker = 
        new Windows.Storage.Pickers.FileOpenPicker();
    openPicker.SuggestedStartLocation = 
        Windows.Storage.Pickers.PickerLocationId.PicturesLibrary;
    openPicker.ViewMode = 
        Windows.Storage.Pickers.PickerViewMode.Thumbnail;

    // Filter to include a sample subset of file types.
    openPicker.FileTypeFilter.Clear();
    openPicker.FileTypeFilter.Add(".bmp");
    openPicker.FileTypeFilter.Add(".png");
    openPicker.FileTypeFilter.Add(".jpeg");
    openPicker.FileTypeFilter.Add(".jpg");

    // Open the file picker.
    Windows.Storage.StorageFile file = 
        await openPicker.PickSingleFileAsync();

    // 'file' is null if user cancels the file picker.
    if (file != null)
    {
        // Open a stream for the selected file.
        // The 'using' block ensures the stream is disposed
        // after the image is loaded.
        using (Windows.Storage.Streams.IRandomAccessStream fileStream =
            await file.OpenAsync(Windows.Storage.FileAccessMode.Read))
        {
            // Set the image source to the selected bitmap.
            Windows.UI.Xaml.Media.Imaging.BitmapImage bitmapImage =
                new Windows.UI.Xaml.Media.Imaging.BitmapImage();

            bitmapImage.SetSource(fileStream);
            image1.Source = bitmapImage;
        }
    }
}
```

This example shows how to programmatically access an image file from the Pictures library and set it as the Source of an [Image](image.md) control. To access the content of the Pictures library programmatically, call [StorageFolder.GetFilesAsync](../windows.storage/storagefolder_getfilesasync_1429382825.md). Remember that you need to specify a capability to access the Pictures library programmatically.

```csharp
protected async override void OnNavigatedTo(NavigationEventArgs e)
{
    // Get the Pictures library
    Windows.Storage.StorageFolder picturesFolder = 
        Windows.Storage.KnownFolders.PicturesLibrary;
    IReadOnlyList<StorageFolder> folders = 
        await picturesFolder.GetFoldersAsync();
    
    // Process file folders
    foreach (StorageFolder folder in folders)
    {
        // Get and process files in folder
        IReadOnlyList<StorageFile> fileList = await folder.GetFilesAsync();
        foreach (StorageFile file in fileList)
        {
            Windows.UI.Xaml.Media.Imaging.BitmapImage bitmapImage = 
                new Windows.UI.Xaml.Media.Imaging.BitmapImage();

            // Open a stream for the selected file.
            // The 'using' block ensures the stream is disposed
            // after the image is loaded.
            using (Windows.Storage.Streams.IRandomAccessStream fileStream = 
                await file.OpenAsync(Windows.Storage.FileAccessMode.Read))
            {
                // Set the image source to the selected bitmap.
                Windows.UI.Xaml.Media.Imaging.BitmapImage bitmapImage =
                    new Windows.UI.Xaml.Media.Imaging.BitmapImage();
                bitmapImage.SetSource(fileStream);

                // Create an Image control.  
                Image img = new Image();
                img.Height = 50;
                img.Source = bitmapImage;

                // Add the Image control to the UI. 'imageGrid' is a
                // VariableSizedWrapGrid declared in the XAML page.
                imageGrid.Children.Add(img);
            }
        }
    }
}
```

### Image sources and scaling

If you are referencing images that are packaged in your app, you should create your image sources at several recommended sizes, to ensure that your app looks great when the Windows Runtime scales it. When specifying a Source for an [Image](image.md) as a Uniform Resource Identifier (URI), you can use a naming convention that will automatically reference the correct image resource for the current scaling as detected by the system at run-time. For specifics of the naming convention and more info, see [Quickstart: Using file or image resources](/previous-versions/windows/apps/hh965325(v=win.10)).

For more info on how to design for scaling, see [Screen sizes and breakpoints](/windows/uwp/layout/screen-sizes-and-breakpoints-for-responsive-design) or Remarks in [Image](image.md).

### Image sources and resource qualifiers

You can use automatic handling for accessing unqualified resources with current scale and culture qualifiers, or you can use [ResourceManager](../windows.applicationmodel.resources.core/resourcemanager.md) and [ResourceMap](../windows.applicationmodel.resources.core/resourcemap.md) with qualifiers for culture and scale to obtain the resources directly. For more info see [Resource management system](/windows/uwp/app-resources/resource-management-system) or Remarks in [Image](image.md). For more info on app resources and how to package image sources in an app, see [Defining app resources](/previous-versions/windows/apps/hh965321(v=win.10)).

## -examples

## -see-also
[ImageFailed](image_imagefailed.md), [ImageOpened](image_imageopened.md), [BitmapSource](../windows.ui.xaml.media.imaging/bitmapsource.md), [Image and ImageBrush](/windows/uwp/controls-and-patterns/images-imagebrushes), [XAML images sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/XAML%20images%20sample)
