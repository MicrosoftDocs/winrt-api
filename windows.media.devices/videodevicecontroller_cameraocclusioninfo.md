---
-api-id: P:Windows.Media.Devices.VideoDeviceController.CameraOcclusionInfo
-api-type: winrt property
---

# Windows.Media.Devices.VideoDeviceController.CameraOcclusionInfo

<!--
public Windows.Media.Devices.CameraOcclusionInfo CameraOcclusionInfo { get; }
-->


## -description

Gets a [CameraOcclusionInfo](videodevicecontroller_cameraocclusioninfo.md) object that can be used to get the current occlusion state of a camera and receive notifications when the occlusion state changes.

## -property-value

The [CameraOcclusionInfo](videodevicecontroller_cameraocclusioninfo.md) for the capture device.

## -remarks

You should only use the shutter state data obtained through this property while the camera is actively streaming. Apps should respond in a logical manner when they detect that the shutter is closed. This should include an in-app message to open the shutter. Applications must not automatically take an action (e.g., turning the camera off) or block the user from doing an action (e.g., turning on the camera) based on the shutter state, as not every camera will reliably report the shutter state when not streaming. Applications must not treat the reported shutter state as an absolute privacy indicator – it is only a notification that the camera believes the shutter is closed.


## -see-also

## -examples

The following example code illustrates the use of the **CameraOcclusionInfo** class to monitor the occlusion state of the camera.

```csharp
protected override async void OnNavigatedTo(NavigationEventArgs e)
{
    await mediaCapture.InitializeAsync();

    var occlusionInfo = mediaCapture.VideoDeviceController.CameraOcclusionInfo;
    occlusionInfo.StateChanged += CameraOcclusionInfo_StateChanged;

}

private void CameraOcclusionInfo_StateChanged(CameraOcclusionInfo sender, CameraOcclusionStateChangedEventArgs args)
{
    if (args.State.IsOccluded)
    {
        String occlusionString = "";
        if (args.State.IsOcclusionKind(CameraOcclusionKind.Lid))
        {
            occlusionString = "Lid";
        }
        else if (args.State.IsOcclusionKind(CameraOcclusionKind.CameraHardware))
        {
            occlusionString = "Camera Hardware";
        }
        else
        {
            occlusionString = "Unknown";
        }
        Debug.WriteLine(String.Format("The camera view is blocked by {0}", occlusionString);
    }
    else
    {
        Debug.WriteLine("Camera is not occluded");
    }
}
```
