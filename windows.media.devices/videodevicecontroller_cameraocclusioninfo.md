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
