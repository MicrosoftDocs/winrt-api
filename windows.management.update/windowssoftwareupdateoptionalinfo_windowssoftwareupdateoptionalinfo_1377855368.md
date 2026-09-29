---
-api-id: M:Windows.Management.Update.WindowsSoftwareUpdateOptionalInfo.#ctor(Windows.Foundation.IReference{Windows.Management.Update.WindowsSoftwareUpdateCategory},Windows.Foundation.Collections.IIterable{Windows.Management.Update.WindowsSoftwareUpdateLocalizationInfo},Windows.Foundation.IReference{System.Int32},Windows.Foundation.IReference{System.Int32})
-api-type: winrt constructor
---

# Windows.Management.Update.WindowsSoftwareUpdateOptionalInfo.#ctor(Windows.Foundation.IReference{Windows.Management.Update.WindowsSoftwareUpdateCategory},Windows.Foundation.Collections.IIterable{Windows.Management.Update.WindowsSoftwareUpdateLocalizationInfo},Windows.Foundation.IReference{System.Int32},Windows.Foundation.IReference{System.Int32})

<!--
public WindowsSoftwareUpdateOptionalInfo (System.Nullable<Windows.Management.Update.WindowsSoftwareUpdateCategory> category, System.Collections.Generic.IEnumerable<Windows.Management.Update.WindowsSoftwareUpdateLocalizationInfo> localizationInfo, System.Nullable<int> complianceDeadlineInDays, System.Nullable<int> complianceGracePeriodInDays);
-->


## -description

Creates a new [WindowsSoftwareUpdateOptionalInfo](./windowssoftwareupdateoptionalinfo.md). Any argument can be `null` when the corresponding metadata isn't provided.

## -parameters

### -param category

An optional [WindowsSoftwareUpdateCategory](./windowssoftwareupdatecategory.md) that classifies the update, or `null`.

### -param localizationInfo

An optional collection of [WindowsSoftwareUpdateLocalizationInfo](./windowssoftwareupdatelocalizationinfo.md) entries that provide localized titles and descriptions, or `null`.

### -param complianceDeadlineInDays

An optional number of days before the update must be installed to remain compliant, or `null`.

### -param complianceGracePeriodInDays

An optional number of grace-period days allowed after the compliance deadline, or `null`.

## -remarks


## -see-also

[WindowsSoftwareUpdateOptionalInfo](./windowssoftwareupdateoptionalinfo.md)

## -examples

