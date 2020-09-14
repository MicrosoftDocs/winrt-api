---
-api-id: M:Windows.System.UserProfile.GlobalizationPreferences.TrySetLanguages(Windows.Foundation.Collections.IIterable{System.String})
-api-type: winrt method
---

<!-- Method syntax.
public bool GlobalizationPreferences.TrySetLanguages(IIterable<String> languageTags)
-->

# Windows.System.UserProfile.GlobalizationPreferences.TrySetLanguages

## -description

Attempts to set the preferred languages on an [IoT](https://developer.microsoft.com/en-us/windows/iot) device.

> [!NOTE]
> This method is available only in [Embedded mode](/windows/iot-core/develop-your-app/EmbeddedMode). 

## -parameters
### -param languageTags

One or more language identifiers for the user's preferred languages.

## -returns

**true** if Languages was set; otherwise, **false**.

## -remarks
 Your app must declare the **systemManagement** capability, which lets apps access basic system administration privileges including locale, timezone, shut down, and reboot.

The systemManagement capability must include the iot namespace when you declare it in your app's package manifest.

```xml
<Capabilities><iot:Capability Name="systemManagement"/></Capabilities>
```

## -see-also

## -examples