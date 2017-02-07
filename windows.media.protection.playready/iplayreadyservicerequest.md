---
-api-id: T:Windows.Media.Protection.PlayReady.IPlayReadyServiceRequest
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IPlayReadyServiceRequest : Windows.Media.Protection.IMediaProtectionServiceRequest
-->

# Windows.Media.Protection.PlayReady.IPlayReadyServiceRequest

## -description
Base interface for all service request interfaces.

## -remarks
All PlayReady service request objects support all the methods in this interface with the exceptions of [PlayReadyIndividualizationServiceRequest](playreadyindividualizationservicerequest.md) and [PlayReadyRevocationServiceRequest](playreadyrevocationservicerequest.md). **IPlayReadyIndividualizationServiceRequest** and **IPlayReadyRevocationServiceRequest** only support [BeginServiceRequest](iplayreadyservicerequest_beginservicerequest.md) and [NextServiceRequest](iplayreadyservicerequest_nextservicerequest.md).

Some properties are only available for retrieval after the service request is complete. These will be explicitly indicated.

No properties can be set after **BeginServiceRequest** or [GenerateManualEnablingChallenge](iplayreadyservicerequest_generatemanualenablingchallenge.md) has been called. These methods effectively put the interface into a read-only state.

The only **IPlayReadyServiceRequest** that can be created if the machine is not individualized is **IPlayReadyIndividualizationServiceRequest**. All others return MSPR_E_NEEDS_INDIVIDUALIZATION until individualization occurs successfully.

## -examples

## -see-also
[IMediaProtectionServiceRequest](../windows.media.protection/imediaprotectionservicerequest.md)