---
-api-id: M:Windows.ApplicationModel.LimitedAccessFeatures.TryUnlockFeature(System.String,System.String,System.String)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public LimitedAccessFeatureRequestResult LimitedAccessFeatures.TryUnlockFeature(String featureId, String token, String attestation)
-->

# Windows.ApplicationModel.LimitedAccessFeatures.TryUnlockFeature

## -description

Submits a request to Microsoft to authorize use of a specific Limited Access Feature. Users must have previously obtained a feature ID and a token from Microsoft in order to successfully call this API.

## -parameters
### -param featureId

The ID, provided by Microsoft. that identifies the feature being requested.

### -param token

The string receieved from Microsoft upon agreeing to the requirements for use of the feature.

### -param attestation

A plain-english statement declaring that the publisher has permission to use the feature.

## -returns

A [LimitedAccessFeatureRequestResult](limitedaccessfeaturerequestresult.md) value indicating the response to the user request.

## -remarks

## -see-also

## -examples

