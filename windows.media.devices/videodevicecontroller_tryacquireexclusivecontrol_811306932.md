---
-api-id: M:Windows.Media.Devices.VideoDeviceController.TryAcquireExclusiveControl(System.String,Windows.Media.Capture.MediaCaptureDeviceExclusiveControlReleaseMode)
-api-type: winrt method
---

# Windows.Media.Devices.VideoDeviceController.TryAcquireExclusiveControl(System.String,Windows.Media.Capture.MediaCaptureDeviceExclusiveControlReleaseMode)

<!--
public bool TryAcquireExclusiveControl (string deviceId, Windows.Media.Capture.MediaCaptureDeviceExclusiveControlReleaseMode mode);
-->


## -description

Requests exclusive control of the camera with the specified device ID.

## -parameters

### -param deviceId

The device ID of the camera for which exclusive control is requested. The device ID can be obtained with the [DeviceInformation](xref:Windows.Devices.Enumeration.DeviceInformation) class.

### -param mode

A value from the [MediaCaptureDeviceExclusiveControlReleaseMode](xref:Windows.Media.Capture.MediaCaptureDeviceExclusiveControlReleaseMode) enumeration specifying the conditions under which exclusive control is released.

## -returns

True if exclusive control of the camera was acquired; otherwise, false.

## -remarks

## -see-also

## -examples

This example demonstrates how an application using camera in exclusive control can ensure that camera configuration is set before start of capture and will not be altered by another application that has access to this camera by acquiring the exclusive control lock ahead of it.

```csharp
private static System.Threading.ManualResetEvent _exclusiveLockAcquire = new System.Threading.ManualResetEvent(false);

public static void RecordVideo()
{
    MediaCapture mediacapture = new MediaCapture();
    await mediacapture.InitializeAsync();

    mediacapture.CaptureDeviceExclusiveControlStatusChanged += 
Mediacapture_CaptureDeviceExclusiveControlStatusChanged;

    _exclusiveLockAcquire.WaitOne();
    _exclusiveLockAcquire.Reset();
            
    // configure camera - blocking other application from changing the configuration.

    // record video
}

private static void Mediacapture_CaptureDeviceExclusiveControlStatusChanged(MediaCapture sender, MediaCaptureDeviceExclusiveControlStatusChangedEventArgs args)
{
    if (args.Status == MediaCaptureDeviceExclusiveControlStatus.ExclusiveControlAvailable)
    {
        if (sender.VideoDeviceController().TryAcquireExclusiveControl(
            args.DeviceId(),     
            MediaCaptureDeviceExclusiveControlReleaseMode.OnAllStreamsStopped))
        {
            _exclusiveLockAcquire.Set();
        }
    }
}

```


