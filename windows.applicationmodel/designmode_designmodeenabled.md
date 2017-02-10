---
-api-id: P:Windows.ApplicationModel.DesignMode.DesignModeEnabled
-api-type: winrt property
---

<!-- Property syntax
public bool DesignModeEnabled { get; }
-->

# Windows.ApplicationModel.DesignMode.DesignModeEnabled

## -description
Gets a value that indicates whether the process is running in design mode.

## -property-value
True if the process is running in design mode; otherwise false.

## -remarks
Use the [DesignModeEnabled](designmode_designmodeenabled.md) property when your custom types require special logic when running in a visual designer. For example, a Windows Library for JavaScript control can query the [DesignModeEnabled](designmode_designmodeenabled.md) property to determine whether to display placeholder data instead of live data from a web service.

Your in-process custom types can check the design mode setting of the current process. Also, internal custom types that are activated in another process can check whether their caller is in design mode.



> [!NOTE]
> The [DesignModeEnabled](designmode_designmodeenabled.md) property is available only in the presence of a developer certificate.

## -examples

## -see-also
