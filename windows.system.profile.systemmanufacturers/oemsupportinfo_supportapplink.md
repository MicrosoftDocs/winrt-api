---
-api-id: P:Windows.System.Profile.SystemManufacturers.OemSupportInfo.SupportAppLink
-api-type: winrt property
---

<!-- Property syntax.
public Uri SupportAppLink { get; }
-->

# Windows.System.Profile.SystemManufacturers.OemSupportInfo.SupportAppLink

## -description
Gets the protocol handler link to the OEM-built support app that will be launched instead of the web URL.

## -property-value
The protocol handler link to the OEM-built support app.

## -remarks

## -see-also

## -examples
In the following app manifest file snippet, the **Protocol Name** is **contoso-contact-support** so this will be the value that will be used for **SupportAppLink**.

```xml
<Extensions>
  <uap:Extension Category="windows.protocol">
    <uap:Protocol Name="contoso-contact-support">
      <uap:DisplayName>contoso-resource:appDisplayName</uap:DisplayName>
    </uap:Protocol>
  </uap:Extension>
</Extensions>
```
