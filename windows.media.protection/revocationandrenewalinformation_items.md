---
-api-id: P:Windows.Media.Protection.RevocationAndRenewalInformation.Items
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVector<Windows.Media.Protection.RevocationAndRenewalItem> Items { get; }
-->

# Windows.Media.Protection.RevocationAndRenewalInformation.Items

## -description
Returns a list of components that need to be revoked and renewed with updated components.

## -property-value
List of components that need to be revoked and renewed.

## -remarks
If there are no entries in the list, it indicates that basic system components are compromised. In that case, recovery can be attempted by invoking [ComponentRenewal.RenewSystemComponentsAsync](componentrenewal_renewsystemcomponentsasync.md).

If there is a single entry in the list, the entry may indicate that the system’s revocation list (active.grl) needs updating. This usually means that the content protection system requires updates of components. This is often the first indication that components need updating. Recovery can be attempted by invoking [ComponentRenewal.RenewSystemComponentsAsync](componentrenewal_renewsystemcomponentsasync.md).

## -examples

## -see-also
