---
-api-id: T:Windows.Media.Protection.PlayReady.PlayReadyIndividualizationServiceRequest
-api-type: winrt class
---

<!-- Class syntax.
public class PlayReadyIndividualizationServiceRequest : Windows.Media.Protection.IMediaProtectionServiceRequest, Windows.Media.Protection.PlayReady.IPlayReadyIndividualizationServiceRequest, Windows.Media.Protection.PlayReady.IPlayReadyServiceRequest
-->

# Windows.Media.Protection.PlayReady.PlayReadyIndividualizationServiceRequest

## -description
Provides the service methods for requesting platform individualization.

## -remarks
This class can be created proactively, returned from a previous service request operation, or delivered to the application through the **MediaProtectionManager.ServiceRequested** event.

The process of individualization is not configurable by an app, so this class has no methods or properties beyond that of the [IPlayReadyServiceRequest](iplayreadyservicerequest.md) base class. It is provided for type completeness and as a concrete activatable class.

## -examples

## -see-also
[IPlayReadyServiceRequest](iplayreadyservicerequest.md), [IMediaProtectionServiceRequest](../windows.media.protection/imediaprotectionservicerequest.md)