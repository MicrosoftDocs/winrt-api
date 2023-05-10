---
-api-id: T:Windows.Networking.XboxLive.XboxLiveEndpointPairCreationResult
-api-type: winrt class
---

<!-- Class syntax.
public class XboxLiveEndpointPairCreationResult : Windows.Networking.XboxLive.IXboxLiveEndpointPairCreationResult
-->

# Windows.Networking.XboxLive.XboxLiveEndpointPairCreationResult

## -description

Encapulates the results of an attempt to instantiate a new **XboxLiveEndpointPair**. Includes a status value specifying the result of the attempt and (when the creation was successful) details about the resulting endpoint pair.

> [!IMPORTANT]
> This API is not available to all apps. Unless your developer account is specially provisioned by Microsoft, calls to these APIs will fail at runtime.

## -remarks

You don't instantiate this class using a constructor. Instead, an instance is created and returned to your code inside the **IAsyncOperation(XboxLiveEndpointPairCreationResult)** object returned by a call to **XboxLiveEndpointPairTemplate.CreateEndpointPairAsync**.

## -examples

## -see-also
