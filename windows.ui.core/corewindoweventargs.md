---
-api-id: T:Windows.UI.Core.CoreWindowEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class CoreWindowEventArgs : Windows.UI.Core.ICoreWindowEventArgs
-->

# Windows.UI.Core.CoreWindowEventArgs

## -description
Contains the set of arguments returned to an app after a window input or behavior event.

## -remarks
This object is passed to the app in the corresponding event delegate. The app can use this to set the [Handled](icorewindoweventargs_handled.md) property, which, when true, informs the framework to perform default processing of the event.

<!-- confirmed -->
> [!NOTE]
> This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](/cpp/cppcx/threading-and-marshaling-c-cx).

## -examples

## -see-also
