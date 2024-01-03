---
-api-id: N:Windows.Management.Update
-api-type: winrt namespace
---

<!-- Namespace syntax.
namespace Windows.Management.Update 
-->

# Windows.Management.Update

## -description
The types in this namespace allow users to opt in or out of receiving Windows Insider Preview builds on their device. The APIs are intended to be used by IoT original equipment manufacturers (OEMs).

## -remarks

These APIs allow an IoT device to receive Windows Insider Preview builds. It's expected that the OEM of the device will create a settings page within the [Windows Device Portal](/windows/iot-core/manage-your-device/deviceportal) for device configuration properties. At a high level, information from [PreviewBuildsState](./previewbuildsstate.md) will be read by the device, then displayed to the user, and then used to register the user's account to the device. After registration, all settings management will be done online through the Windows Insider Program instead of on the device itself. 

## -examples

This C# example demonstrates how a user can determine whether their device is receiving preview builds, or whether there are problems preventing the device from getting preview builds.

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

## -see-also
