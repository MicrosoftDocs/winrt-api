---
-api-id: T:Windows.Management.Update.PreviewBuildsManager
-api-type: winrt class
---

<!-- Class syntax.
public class PreviewBuildsManager 
-->

# Windows.Management.Update.PreviewBuildsManager

## -description
Manages the state of preview builds for the device.

## -remarks

## -see-also

## -examples
As an examples, after enabling Windows Insider Preview builds in the device's settings page an OEM device developer might use this code example to get an activation code to register the device within the Windows Insider Registration Portal.

```csharp
public async Task<string> ActivateDevice() 
{ 
    PreviewBuildsManager manager = PreviewBuildsManager.GetDefault(); 
    if (manager != null) 
    { 
        // The user wants to activate their device to receive Windows Insider Preview Builds 
        manager.ArePreviewBuildsAllowed = true; 

        await manager.SyncAsync(); 

        PreviewBuildsState state = manager.GetCurrentState(); 
        string activationCode; 
        if (state.Properties.ContainsKey("ActivationCode")) 
        { 
            return state.Properties["ActivationCode"].ToString(); 
        } 
    } 
    return String.Empty; 
} 
```

