---
-api-id: P:Windows.Networking.XboxLive.XboxLiveEndpointPairCreationResult.IsExistingPathEvaluation
-api-type: winrt property
---

<!-- Property syntax
public bool IsExistingPathEvaluation { get; }
-->

# Windows.Networking.XboxLive.XboxLiveEndpointPairCreationResult.IsExistingPathEvaluation

## -description

Gets a Boolean value that is `true` if the endpoint pair being returned already existed.

> [!IMPORTANT]
> This API is not available to all apps. Unless your developer account is specially provisioned by Microsoft, calls to these APIs will fail at runtime.

## -property-value

`True` if the returned endpoint pair already existed. `False` if the endpoint pair didn't previously exist, or the creation operation used **XboxLiveEndpointPairCreationBehaviors.ReevaluatePath** and the re-evaluation found a new path.

## -remarks

## -examples

## -see-also
