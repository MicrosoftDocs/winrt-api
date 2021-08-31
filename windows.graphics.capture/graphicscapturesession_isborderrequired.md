---
-api-id: P:Windows.Graphics.Capture.GraphicsCaptureSession.IsBorderRequired
-api-type: winrt property
---

# Windows.Graphics.Capture.GraphicsCaptureSession.IsBorderRequired

<!--
public bool IsBorderRequired { get; set; }
-->


## -description

Gets or sets a value specifying whether the capture operation requires a colored border around the window or display to indicate that a capture is in progress.

## -property-value

**true** if the border is required; otherwise, false.

## -remarks

Before the system will disable the colored border around the a window or display that is being captured, your app must get consent from the user by calling [GraphicsCaptureAccess.RequestAccessAsync](graphicscaptureaccess_requestaccessasync_1551329835.md), passing in the value [GraphicsCaptureAccessKind.Borderless](graphicscaptureaccesskind.md), which displays a prompt to the user. If the user denies access, setting this property to **false** will succeed, but the value will be ignored and the border will be displayed during subsequent captured. To call **RequestAccessAsync** with **GraphicsCaptureAccessKind.Borderless**, you must declare the **graphicsCaptureWithoutBorder** capability in your app's package manifest. For more information, see [App capability declarations](/windows/uwp/packaging/app-capability-declarations).

Note that if the **IsBorderRequired** property is set to **true** for the same window or display by other apps on the device, the border will be displayed.

## -see-also

## -examples


