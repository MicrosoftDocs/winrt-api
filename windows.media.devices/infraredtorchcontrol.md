---
-api-id: T:Windows.Media.Devices.InfraredTorchControl
-api-type: winrt class
ms.custom: 19H1
---

<!-- Class syntax.
public class InfraredTorchControl 
-->

# Windows.Media.Devices.InfraredTorchControl

## -description
Provides functionality for controlling the infrared torch LED settings on a capture device.

## -remarks
The InfraredTorchControl enables apps to control the power and behavior of the Infrared LED. 

You can find out if a device supports this control by checking [InfraredTorchControl.IsSupported](infraredtorchcontrol_issupported.md).

You can access the InfraredTorchControl for the capture device through [MediaCapture.VideoDeviceController](../windows.media.capture/mediacapture_videodevicecontroller.md).

## -see-also
[MediaCapture.VideoDeviceController](../windows.media.capture/mediacapture_videodevicecontroller.md)

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

    if (!TryIncrementInfraredPower())
    {
        Debug.WriteLine("Failed to increment InfraredTorch power");
    }
}

private bool TryIncrementInfraredPower()
{
    bool incrementSucceeded = false;
    
    if (mediaCapture.VideoDeviceController.InfraredTorchControl.IsSupported)
    {
        Debug.WriteLine("IR torch supported");
        InfraredTorchControl infraredTorchControl = mediaCapture.VideoDeviceController.InfraredTorchControl;
        var maxPower = infraredTorchControl.MaxPower;
        var powerStep = infraredTorchControl.PowerStep;
        var oldPower = infraredTorchControl.Power;

        if (oldPower < maxPower)
        {
            infraredTorchControl.Power = oldPower + powerStep;
            incrementSucceeded = true;
        }
        else
        {
            Debug.WriteLine("InfraredTorch is already at max power");
        }
    }
    
    return incrementSucceeded;
}
```

