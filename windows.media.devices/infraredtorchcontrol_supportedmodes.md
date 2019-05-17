---
-api-id: P:Windows.Media.Devices.InfraredTorchControl.SupportedModes
-api-type: winrt property
ms.custom: 19H1
---

<!-- Property syntax.
public IVectorView<InfraredTorchMode> SupportedModes { get; }
-->

# Windows.Media.Devices.InfraredTorchControl.SupportedModes

## -description
SupportedModes property is used to find out modes that the infrared LED supports.

## -property-value
Read-only list of supported [InfraredTorchModes](infraredtorchmode.md).

## -remarks

## -see-also
[InfraredTorchMode](infraredtorchmode.md)

## -examples
```
using Windows.Media.Capture;

MediaCapture mediaCapture = new MediaCapture();

public MainPage()
{
    this.InitializeComponent();
}

protected override async void OnNavigatedTo(NavigationEventArgs e)
{
    await mediaCapture.InitializeAsync();

    // Preview is Windows.UI.Xaml.Controls.CaptureElement defined in XAML file
    // and used to render camera preview
    Preview.Source = mediaCapture;
    await mediaCapture.StartPreviewAsync();

    if (mediaCapture.VideoDeviceController.InfraredTorchControl.IsSupported)
    {
        Debug.WriteLine("IR torch supported");

        IEnumerable<InfraredTorchMode> supportedModes = 
            mediaCapture.VideoDeviceController.InfraredTorchControl.SupportedModes;
        foreach (InfraredTorchMode supportedMode in supportedModes)
        {
            Debug.WriteLine($"This infrared LED supports mode {supportedMode}");
        }
    }
    else
    {
        Debug.WriteLine("IR torch NOT supported");
    }
}
```
