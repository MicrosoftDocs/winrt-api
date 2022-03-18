---
-api-id: P:Windows.Media.Protection.MediaProtectionManager.Properties
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IPropertySet Properties { get; }
-->

# Windows.Media.Protection.MediaProtectionManager.Properties

## -description
Gets a PropertySet object containing any properties attached to the protection manager.

## -property-value
The PropertySet object that contains the properties for this protection manager.

## -remarks
The following properties are defined:<table>
   <tr><th>Name</th><th>Type</th><th>Description</th></tr>
   <tr><td>Windows.Media.Protection.VideoFrameAccessCertificate</td><td>UINT8 Array</td><td>Application certificate for accessing frames in frame server mode.</td></tr>
   <tr><td>Windows.Media.Protection.MediaProtectionSystemId</td><td>GUID</td><td>Protection System ID</td></tr>
   <tr><td>Windows.Media.Protection.MediaProtectionSystemContext</td><td>UINT8 Array</td><td>Data associated with protection system for the current content.</td></tr>
   <tr><td>Windows.Media.Protection.MediaProtectionSystemIdMapping</td><td>IPropertySet</td><td>Returns a mapping of the protection system id to the string for activating the trusted input object. The string for the protection system id must be in the format of a GUID (include {}) in upper case. This maps to a class name in the content protection system.</td></tr>
   <tr><td>Windows.Media.Protection.MediaProtectionContainerGuid</td><td>GUID</td><td>Specifies the Digital Rights Management (DRM) scheme.</td></tr>
</table>

## -examples
```csharp
var cpsystems = new Windows.Foundation.Collections.PropertySet();

cpsystems["{1891D602-6F0A-40F7-90A1-3C24564F6D77}"] = "TestDRMInstall.Objects.AsfTrustedInput";

contentProtectionManager.Properties["Windows.Media.Protection.MediaProtectionSystemIdMapping"] = cpsystems;
```



## -see-also
