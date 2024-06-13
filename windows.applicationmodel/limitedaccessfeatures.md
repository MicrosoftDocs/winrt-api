---
-api-id: T:Windows.ApplicationModel.LimitedAccessFeatures
-api-type: winrt class
ms.custom: RS5
---

<!-- Class syntax.
public class LimitedAccessFeatures 
-->

# Windows.ApplicationModel.LimitedAccessFeatures

## -description

This API enables applications to request access to Limited Access Features.

## -remarks

Limited Access Features are Windows platform features which require specific approval to be used in an application. This may be because these are features which are not ready for broad consumption, or because these are features which have legitimate use-cases but may be abused by malicious apps.

To use a Limited Access Feature in your app, you need explicit permission from Microsoft. You cannot call the APIs needed to enable one of these features without a specific feature ID and use token. For more information about any Limited Access Feature or to request an unlock token, please use the [LAF Access Token Request Form](https://go.microsoft.com/fwlink/?linkid=2271232&clcid=0x409).

## -see-also

## -examples

