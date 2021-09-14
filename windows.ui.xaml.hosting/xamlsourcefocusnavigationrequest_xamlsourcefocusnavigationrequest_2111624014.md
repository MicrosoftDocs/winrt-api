---
-api-id: M:Windows.UI.Xaml.Hosting.XamlSourceFocusNavigationRequest.#ctor(Windows.UI.Xaml.Hosting.XamlSourceFocusNavigationReason,Windows.Foundation.Rect,System.Guid)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public XamlSourceFocusNavigationRequest.XamlSourceFocusNavigationRequest(XamlSourceFocusNavigationReason reason, Rect hintRect, Guid correlationId)
-->

# Windows.UI.Xaml.Hosting.XamlSourceFocusNavigationRequest.XamlSourceFocusNavigationRequest

## -description
Initializes a new instance of the [XamlSourceFocusNavigationRequest](xamlsourcefocusnavigationrequest.md) class with the reason for the navigation request, the bounding rectangle that will receive navigation focus, and the unique correlation ID for the request.


## -parameters
### -param reason
A value that indicates the reason for the navigation request.

### -param hintRect
The bounding rectangle of the element in the desktop application that is losing focus (that is, the element that had focus before the [DesktopWindowXamlSource](desktopwindowxamlsource.md) received focus). This parameter is used to provide context to the UWP XAML framework when the user enters the **DesktopWindowXamlSource** by using a 4-direction navigation experience (for example, by using keyboard arrow keys). For more information, see the remarks.

### -param correlationId
The unique identifier for the navigation request. You can use this parameter for logging purposes, or if you have an existing correlation ID from an in-progress focus movement already in progress and you want to connect that focus movement with the current navigation request.

## -remarks
The *hintRect* parameter is used to provide context to the UWP XAML framework when the user enters the **DesktopWindowXamlSource** by using a 4-direction navigation experience (for example, by using keyboard arrow keys) with [Reason](xamlsourcefocusnavigationrequest_reason.md) values of **Left**, **Right**, **Top**, or **Down**. For example, suppose that to the left of the **DesktopWindowXamlSource** are three WPF buttons and inside the **DesktopWindowXamlSource** are three UWP buttons, so in total there is a 3x2 grid of buttons across two UI frameworks. When the user presses the right arrow on the keyboard from the middle WPF button, you want focus to move to the middle UWP button in the **DesktopWindowXamlSource**. To accomplish this, pass the bounding rectangle of the middle WPF button to the *hintRect* parameter and specify **Right** for the *reason* parameter.

## -see-also

## -examples
