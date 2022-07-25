---
-api-id: P:Windows.UI.Xaml.DebugSettings.IsBindingTracingEnabled
-api-type: winrt property
---

<!-- Property syntax
public bool IsBindingTracingEnabled { get;  set; }
-->

# Windows.UI.Xaml.DebugSettings.IsBindingTracingEnabled

## -description
Gets or sets a value that indicates whether to engage the binding tracing feature of Microsoft Visual Studio when the app runs.



## -property-value
**true** to engage the binding tracing feature of Microsoft Visual Studio; otherwise, **false**.

## -remarks
This property is **true** by default, but for binding tracing to work, you must also select **Mixed** debugger type in Microsoft Visual Studio on the **Debug** page of the project designer.

When binding tracing is enabled and you run your app with the debugger attached, any binding errors appear in the **Output** window in Microsoft Visual Studio.

## -examples

## -see-also
[BindingFailed](debugsettings_bindingfailed.md), [Data binding in depth](/windows/uwp/data-binding/data-binding-in-depth)
