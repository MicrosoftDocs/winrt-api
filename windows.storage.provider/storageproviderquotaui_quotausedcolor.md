---
-api-id: P:Windows.Storage.Provider.StorageProviderQuotaUI.QuotaUsedColor
-api-type: winrt property
---

# Windows.Storage.Provider.StorageProviderQuotaUI.QuotaUsedColor

<!--
public System.Nullable<Windows.UI.Color> QuotaUsedColor { get; set; }
-->

## -description

The color of the quota bar in the storage provider flyout.

## -property-value

## -remarks

It is expected that the provider will handle theme changes, including high contrast theme changes, appropriately for this value.

If no color is provided, the System accent color defined in Settings [UIColorType](../windows.ui.viewmanagement/uicolortype.md) will be used.

This property is advisory. Windows determines if or how it uses these values.

## -see-also

[StorageProviderQuotaUI](storageproviderquotaui.md)
