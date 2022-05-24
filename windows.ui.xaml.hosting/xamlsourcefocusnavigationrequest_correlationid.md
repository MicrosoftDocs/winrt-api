---
-api-id: P:Windows.UI.Xaml.Hosting.XamlSourceFocusNavigationRequest.CorrelationId
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public Guid CorrelationId { get; }
-->

# Windows.UI.Xaml.Hosting.XamlSourceFocusNavigationRequest.CorrelationId

## -description
Gets the unique identifier for the navigation request. You can use this value for logging purposes, or if you have an existing correlation ID from an in-progress focus movement already in progress and you want to connect that focus movement with a new navigation request.


## -property-value
The unique identifier for the navigation request.

## -remarks
If you use the [XamlSourceFocusNavigationRequest](xamlsourcefocusnavigationrequest_xamlsourcefocusnavigationrequest_2111624014.md) constructor, this property returns the value you passed to the *correlationId* parameter. Otherwise, this property returns a correlation ID that was initialized by the UWP framework.

## -see-also

## -examples
