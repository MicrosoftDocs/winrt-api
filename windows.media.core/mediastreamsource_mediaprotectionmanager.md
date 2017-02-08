---
-api-id: P:Windows.Media.Core.MediaStreamSource.MediaProtectionManager
-api-type: winrt property
---

<!-- Property syntax
public Windows.Media.Protection.MediaProtectionManager MediaProtectionManager { get;  set; }
-->

# Windows.Media.Core.MediaStreamSource.MediaProtectionManager

## -description
Gets or sets the Digital Rights Management (DRM)[MediaProtectionManager](../windows.media.protection/mediaprotectionmanager.md) used to protect the media.

## -property-value
The media protection manager.

## -remarks
If any of the streams are protected, the application must set the [MediaProtectionManager](mediastreamsource_mediaprotectionmanager.md) property on the [MediaStreamSource](mediastreamsource.md).

The [MediaStreamSource](mediastreamsource.md) requires that the following properties be present in the PropertySet object returned by [MediaProtectionManager.Properties](../windows.media.protection/mediaprotectionmanager_properties.md): 
+ [Windows.Media.Protection.MediaProtectionSystemId](../windows.media.protection/mediaprotectionmanager_properties.md)
+ [Windows.Media.Protection.MediaProtectionSystemIdMapping

](../windows.media.protection/mediaprotectionmanager_properties.md)
[MediaStreamSource](mediastreamsource.md) will use the value of the following optional property when initializing the content protection system:
+ [Windows.Media.Protection.MediaProtectionSystemContext](../windows.media.protection/mediaprotectionmanager_properties.md)




## -examples

## -see-also
