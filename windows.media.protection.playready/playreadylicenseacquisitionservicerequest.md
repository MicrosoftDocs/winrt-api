---
-api-id: T:Windows.Media.Protection.PlayReady.PlayReadyLicenseAcquisitionServiceRequest
-api-type: winrt class
---

<!-- Class syntax.
public class PlayReadyLicenseAcquisitionServiceRequest : Windows.Media.Protection.IMediaProtectionServiceRequest, Windows.Media.Protection.PlayReady.IPlayReadyLicenseAcquisitionServiceRequest, Windows.Media.Protection.PlayReady.IPlayReadyLicenseAcquisitionServiceRequest2, Windows.Media.Protection.PlayReady.IPlayReadyLicenseAcquisitionServiceRequest3, Windows.Media.Protection.PlayReady.IPlayReadyServiceRequest
-->

# Windows.Media.Protection.PlayReady.PlayReadyLicenseAcquisitionServiceRequest

## -description
Provides the service methods for obtaining PlayReady licenses.

## -remarks
This class can be created proactively, returned from a previous service request operation, or delivered to the app through the **MediaProtectionManager.ServiceRequested** event.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | SessionId |
| 1703 | 15063 | CreateLicenseIterable |

## -examples

## -see-also
[IPlayReadyLicenseAcquisitionServiceRequest](iplayreadylicenseacquisitionservicerequest.md), [IPlayReadyServiceRequest](iplayreadyservicerequest.md), [IMediaProtectionServiceRequest](../windows.media.protection/imediaprotectionservicerequest.md)
