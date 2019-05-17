---
-api-id: T:Windows.UI.Core.CoreComponentInputSource
-api-type: winrt class
---

<!-- Class syntax.
public class CoreComponentInputSource : Windows.UI.Core.ICoreClosestInteractiveBoundsRequested, Windows.UI.Core.ICoreComponentFocusable, Windows.UI.Core.ICoreInputSourceBase, Windows.UI.Core.ICoreKeyboardInputSource, Windows.UI.Core.ICoreKeyboardInputSource2, Windows.UI.Core.ICorePointerInputSource, Windows.UI.Core.ICoreTouchHitTesting
-->

# Windows.UI.Core.CoreComponentInputSource

## -description
Provides a mechanism to receive input for a XAML framework element hosted in another framework, such as a DirectX interop framework.

## -remarks
The CoreComponentInputSource class enables an app to handle input for a XAML framework element hosted in another framework, such as a DirectX interop framework. Call the [CoreComponentInputSource.DispatcherQueue](corecomponentinputsource_dispatcherqueue.md) property to get the DispatcherQueue of the thread where the CoreComponentInputSource was instantiated.  

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | ClosestInteractiveBoundsRequested |
| 1607 | 14393 | GetCurrentKeyEventDeviceId |
| 1803 | 17134 | DispatcherQueue |

## -examples

## -see-also
[ICoreInputSourceBase](icoreinputsourcebase.md), [ICorePointerInputSource](icorepointerinputsource.md)
