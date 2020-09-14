---
-api-id: M:Windows.System.UserProfile.GlobalizationPreferences.TrySetHomeGeographicRegion(System.String)
-api-type: winrt method
---

<!-- Method syntax.
public bool GlobalizationPreferences.TrySetHomeGeographicRegion(String region)
-->

# Windows.System.UserProfile.GlobalizationPreferences.TrySetHomeGeographicRegion

## -description

Attempts to set the user's home geographic region on an [IoT](https://developer.microsoft.com/en-us/windows/iot) device.

> [!NOTE]
> This method is available only in [Embedded mode](/windows/iot-core/develop-your-app/EmbeddedMode). 

## -parameters
### -param region

The GeographicRegion identifier that represents the user's home location.

## -returns

**true** if HomeGeographicRegion was set; otherwise, **false**.

## -remarks
 Your app must declare the **systemManagement** capability, which lets apps access basic system administration privileges including locale, timezone, shut down, and reboot.

The systemManagement capability must include the iot namespace when you declare it in your app's package manifest.

```xml
<Capabilities><iot:Capability Name="systemManagement"/></Capabilities>
```

## -see-also

## -examples