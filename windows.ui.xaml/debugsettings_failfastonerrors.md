---
-api-id: P:Windows.UI.Xaml.DebugSettings.FailFastOnErrors
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public bool FailFastOnErrors { get;  set; }
-->

# Windows.UI.Xaml.DebugSettings.FailFastOnErrors

## -description

Gets or sets a value that indicates whether XAML errors cause an immediate FailFast rather than returning an error.



## -property-value

**true** if XAML errors cause an immediate FailFast rather than returning an error; otherwise, **false**. The default is **false**.

## -remarks

This property is an aid to help application debugging, but it is not limited to debug builds or use in the debugger. This feature can be enabled by apps even when deployed to the Store.

Enabling FailFastOnErrors lets you find errors earlier, with potentially more usable information. It also causes crashes where errors would otherwise be ignored. For example, with FailFastOnErrors disabled, a XAML Image element raises an Image.ImageFailed event if it can't load an image, but otherwise ignores the error. If FailFastOnErrors is enabled, it will cause the application to crash instead.

The Visual Studio managed code debugger does not break on FailFast errors. You should select the **Mixed** debugger type in Microsoft Visual Studio on the **Debug** page of the project designer.

This property is ignored when code is running in a designer (when [DesignMode.DesignModeEnabled](/windows.applicationmodel/designmode_designmodeenabled.md) is **true**).

When FailFastOnErrors is enabled, the Application.UnhandledException event is not raised.

This property can be changed at any time, not just during app startup.

This property affects all XAML threads in the process.

## -see-also

## -examples

