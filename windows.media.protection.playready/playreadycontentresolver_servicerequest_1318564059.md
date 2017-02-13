---
-api-id: M:Windows.Media.Protection.PlayReady.PlayReadyContentResolver.ServiceRequest(Windows.Media.Protection.PlayReady.PlayReadyContentHeader)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Media.Protection.PlayReady.IPlayReadyServiceRequest ServiceRequest(Windows.Media.Protection.PlayReady.PlayReadyContentHeader contentHeader)
-->

# Windows.Media.Protection.PlayReady.PlayReadyContentResolver.ServiceRequest

## -description
Proactively initiates the service request chain for a given content header.

## -parameters
### -param contentHeader
Content header for the content the app wants to resolve all necessary service request operations.

## -returns
The first service request operation required to resolve the content.

## -remarks
**NULL** is a valid successful response if the content header is already viable for playback.

## -examples

## -see-also
