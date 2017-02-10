---
-api-id: M:Windows.Graphics.Display.DisplayInformation.GetColorProfileAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.Streams.IRandomAccessStream> GetColorProfileAsync()
-->

# Windows.Graphics.Display.DisplayInformation.GetColorProfileAsync

## -description
Asynchronously gets the default International Color Consortium (ICC) color profile that is associated with the physical display.

## -returns
Object that manages the asynchronous retrieval of the color profile.

## -remarks
The asynchronous operation fails if no physical display is attached to the computer on which the app is running (for example, if the app is running over Remote Desktop Connection), if no color profile is associated with the display, or if the profile doesn't match the signature of an ICC color profile. Additionally, not all device families support returning the display's color profile; currently only the Desktop device family implements this API.

Applications should catch any exceptions thrown by this API. In these cases, there is no valid ICC color profile associated with the display, and the app should handle this by assuming a default color space such as sRGB.

## -examples

## -see-also
