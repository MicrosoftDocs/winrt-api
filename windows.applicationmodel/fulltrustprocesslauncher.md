---
-api-id: T:Windows.ApplicationModel.FullTrustProcessLauncher
-api-type: winrt class
---

<!-- Class syntax.
public class FullTrustProcessLauncher 
-->

# Windows.ApplicationModel.FullTrustProcessLauncher

## -description
Activate the full-trust Win32 component of an application from a Universal Windows app component in the same application package.

## -remarks
The methods in this class may only be called by packages that have the **runFullTrust** capability:

```xml
<Package xmlns="http://schemas.microsoft.com/appx/manifest/foundation/windows10" 
         xmlns:uap="http://schemas.microsoft.com/appx/manifest/uap/windows10"
         xmlns:rescap= 
"http://schemas.microsoft.com/appx/manifest/foundation/windows10/restrictedcapabilities" 
         xmlns:desktop="http://schemas.microsoft.com/appx/manifest/desktop/windows10">
  ...
  <Capabilities> 
    <rescap:Capability Name="runFullTrust"/> 
  </Capabilities> 
  <Applications> 
       … 
      <Extensions> 
        <desktop:Extension Category="windows.fullTrustProcess" Executable="fulltrustprocess.exe"> 
          <desktop:FullTrustProcess> 
            <desktop:ParameterGroup GroupId="SyncGroup" Parameters="/Sync"/> 
            <desktop:ParameterGroup GroupId="OtherGroup" Parameters="/Other"/> 
          </desktop:FullTrustProcess> 
        </desktop:Extension> 
      </Extensions> 
    </Application> 
  </Applications>
</Package> 

```



## -examples

## -see-also
