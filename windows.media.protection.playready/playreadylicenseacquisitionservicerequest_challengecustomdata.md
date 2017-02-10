---
-api-id: P:Windows.Media.Protection.PlayReady.PlayReadyLicenseAcquisitionServiceRequest.ChallengeCustomData
-api-type: winrt property
---

<!-- Property syntax
public string ChallengeCustomData { get;  set; }
-->

# Windows.Media.Protection.PlayReady.PlayReadyLicenseAcquisitionServiceRequest.ChallengeCustomData

## -description
Gets or sets the custom data of the request challenge.

## -property-value
The custom data.

## -remarks
Use this property to get the custom data to be placed in the request challenge or to set the challenge custom data to send up as part of the request.

Setting this property is optional.

This property cannot be set after [BeginServiceRequest](playreadylicenseacquisitionservicerequest_beginservicerequest.md) or [GenerateManualEnablingChallenge](playreadylicenseacquisitionservicerequest_generatemanualenablingchallenge.md) have been called.

## -examples

## -see-also
