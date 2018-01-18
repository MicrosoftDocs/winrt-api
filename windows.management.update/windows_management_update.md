---
-api-id: N:Windows.Management.Update
-api-type: winrt namespace
---

<!-- Namespace syntax.
namespace Windows.Management.Update 
-->

# Windows.Management.Update

## -description
This API allows users to opt in or out of receiving Windows Insider Preview Builds on their device. This is especially useful for IoT devices and the maker community. 

## -remarks
Instead of manually building and distributing a pre-release version of Windows, the OEM for the device will create a settings page within [Windows Device Portal](https://docs.microsoft.com/windows/iot-core/manage-your-device/deviceportal) which contains information about the state of the device. Information from [PreviewBuildsState](previewbuildsstate.md) will be read by the device, displayed to the user, and then used to register the user's account to the device. After registration, all settings management will be done through the online through the Windows Insider Program, not the device.

## -see-also
[Windows IoT Core developer documentation](https://docs.microsoft.com/windows/iot-core/)

## -examples
When a user is on the Windows Insider Program settings page created by the device OEM, the device's activation status and information should be displayed on the page. 

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