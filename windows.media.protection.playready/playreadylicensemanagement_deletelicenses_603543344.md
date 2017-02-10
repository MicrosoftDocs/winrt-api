---
-api-id: M:Windows.Media.Protection.PlayReady.PlayReadyLicenseManagement.DeleteLicenses(Windows.Media.Protection.PlayReady.PlayReadyContentHeader)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction DeleteLicenses(Windows.Media.Protection.PlayReady.PlayReadyContentHeader contentHeader)
-->

# Windows.Media.Protection.PlayReady.PlayReadyLicenseManagement.DeleteLicenses

## -description
Deletes licenses that match the specified content header.

## -parameters
### -param contentHeader
Content header with a key identifier with which to match licenses.

## -returns
The asynchronous operation performing the deletion.

## -remarks
Any licenses deleted by this method will have to be reacquired from the license server if the client wants to play back their associated content.

## -examples

## -see-also
