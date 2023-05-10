---
-api-id: T:Windows.Networking.XboxLive.XboxLiveEndpointPairTemplate
-api-type: winrt class
---

<!-- Class syntax.
public class XboxLiveEndpointPairTemplate : Windows.Networking.XboxLive.IXboxLiveEndpointPairTemplate
-->

# Windows.Networking.XboxLive.XboxLiveEndpointPairTemplate

## -description

Represents a pre-configured pattern for how to enable optimal and secure communication between two devices using sockets. The template defined by this class details how two endpoints are connected in an **XboxLiveEndpointPair**. Templates are statically declared in your app's network manifest, and are subsequently identified using unique name strings.

> [!NOTE]
> Templates are declared only in the app's network manifest. You can't declare or modify a template at runtime.

> [!IMPORTANT]
> This API is not available to all apps. Unless your developer account is specially provisioned by Microsoft, calls to these APIs will fail at runtime.

## -remarks

Your code doesn't instantiate this class using a constructor. Instead, you create an instance of a particular predefined template by calling the static **XboxLiveEndpointPairTemplate.GetTemplateByName** method with the name of the template you want.

## -examples

## -see-also
