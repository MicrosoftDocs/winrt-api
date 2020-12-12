---
-api-id: M:Windows.Media.Protection.PlayReady.PlayReadyLicenseSession.#ctor(Windows.Foundation.Collections.IPropertySet)
-api-type: winrt method
---

<!-- Method syntax
public PlayReadyLicenseSession(Windows.Foundation.Collections.IPropertySet configuration)
-->

# Windows.Media.Protection.PlayReady.PlayReadyLicenseSession.PlayReadyLicenseSession

## -description
Initializes a new instance of the [PlayReadyLicenseSession](playreadylicensesession.md) class.

## -parameters
### -param configuration
The configuration data for the license session.

## -remarks
In order for you to make use of the **PlayReadyLicenseSession** class, you must construct it with an **IPropertySet** to be used in the *configuration* parameter. The **IPropertySet** must contain the following:


+ The property  must be set to a valid instance of the [MediaProtectionPMPServer](../windows.media.protection/mediaprotectionpmpserver.md) class.
+ That instance of the **Windows.Media.Protection.MediaProtectionPMPServer** class must have been initialized with an **IPropertySet** that includes the following properties:   +  set to the string value "{F4637010-03C3-42CD-B932-B48ADF3A6A54}".
   +  set to another **IPropertySet**. That last **IPropertySet** must have the property  set to the string value "Windows.Media.Protection.PlayReady.PlayReadyWinRTTrustedInput".



The following JavaScript code demonstrates this process.

```csharp
    var cpsystems = new Windows.Foundation.Collections.PropertySet();       
    cpsystems["{F4637010-03C3-42CD-B932-B48ADF3A6A54}"] = "Windows.Media.Protection.PlayReady.PlayReadyWinRTTrustedInput"; // PlayReady
 
    var pmpSystemInfo = new Windows.Foundation.Collections.PropertySet();
    pmpSystemInfo["Windows.Media.Protection.MediaProtectionSystemId"] = "{F4637010-03C3-42CD-B932-B48ADF3A6A54}";
    pmpSystemInfo["Windows.Media.Protection.MediaProtectionSystemIdMapping"] = cpsystems;
    var pmpServer = new Windows.Media.Protection.MediaProtectionPMPServer( pmpSystemInfo );
 
    var licenseSessionProperties = new Windows.Foundation.Collections.PropertySet();
    licenseSessionProperties["Windows.Media.Protection.MediaProtectionPMPServer"] = pmpServer;

    var licenseSession = new Windows.Media.Protection.PlayReady.PlayReadyLicenseSession( licenseSessionProperties );

```



## -examples

## -see-also
