---
-api-id: N:Windows.Management.Update
-api-type: winrt namespace
---

<!-- Namespace syntax.
namespace Windows.Management.Update 
-->

# Windows.Management.Update

## -description
This API allows users to opt in or out of receiving Windows Insider Preview Builds on their device. This is intended to be used by IoT OEMs  

## -remarks
This API allows an IoT device to receive Windows Insider Preview Builds. It's expected that the OEM of the device will create a settings page within the [Windows Device Portal](https://docs.microsoft.com/windows/iot-core/manage-your-device/deviceportal) for device configuration properties. On a high level, information from [PreviewBuildsState](previewbuildsstate.md) will be read by the device, displayed to the user, and then used to register the user's account to the device. After registration, all settings management will be done through the online through the Windows Insider Program instead of the device itself. 

## -see-also


## -examples
This example demonstrates how a user can determine if their device is receiving preview builds or if there are problems preventing the device from getting preview builds.

```csharp
public string GetErrorMessage() 
{ 
    PreviewBuildsManager manager = PreviewBuildsManager.GetDefault(); 
    if (manager != null) 
    { 
        PreviewBuildsState state = manager.GetCurrentState(); 
        if (state.Properties.ContainsKey("ErrorMessage")) 
        { 
            return state.Properties["ErrorMessage"].ToString(); 
        } 
    } 
    return String.Empty; 
} 
```