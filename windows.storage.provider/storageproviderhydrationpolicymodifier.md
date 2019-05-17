---
-api-id: T:Windows.Storage.Provider.StorageProviderHydrationPolicyModifier
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum StorageProviderHydrationPolicyModifier : uint 
-->

# Windows.Storage.Provider.StorageProviderHydrationPolicyModifier

## -description
Provides policy modifiers to be used with the primary [StorageProviderHydrationPolicy](StorageProviderHydrationPolicy.md).

## -enum-fields
### -field None:0
No modifiers.

### -field ValidationRequired:1
Once the data is hydrated into the file, it will be validated.

### -field StreamingAllowed:2
This modifier does not allow the platform to store any data on disk returned by a sync provider.

### -field AutoDehydrationAllowed:4
Automatic file dehydration is allowed.

## -remarks
ValidationRequired and StreamingAllowed are mutually exclusive fields.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1809 | 17763 | AutoDehydrationAllowed |

## -see-also

## -examples

