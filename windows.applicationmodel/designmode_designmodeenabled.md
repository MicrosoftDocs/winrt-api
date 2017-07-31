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
**True** if the process is running in design mode; otherwise **false**.

## -remarks
Use this property when your custom types require special logic when running in a visual designer. For example, you can query this property to determine whether to display placeholder data instead of live data from a web service.

> [!NOTE]
> The [DesignModeEnabled](designmode_designmodeenabled.md) property is available only in the presence of a developer certificate.

## -examples

## -see-also
[DesignModeEnabled2](designmode_designmode2enabled.md)
