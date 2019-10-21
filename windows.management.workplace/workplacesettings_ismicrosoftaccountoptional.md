---
-api-id: P:Windows.Management.Workplace.WorkplaceSettings.IsMicrosoftAccountOptional
-api-type: winrt property
---

<!-- Property syntax
public bool IsMicrosoftAccountOptional { get; }
-->

# Windows.Management.Workplace.WorkplaceSettings.IsMicrosoftAccountOptional

## -description
Gets a value that indicates whether an enterprise ID can be used instead of a Microsoft account.

## -property-value
**true** if an enterprise ID can be used instead of a Microsoft account; otherwise, **false**.

## -remarks
Some apps, such as the Mail app, require that a user sign in with a Microsoft account. If IsMicrosoftAccountOptional is **true**, the app can provide a different experience in an enterprise setting, and let a user sign in with an enterprise ID instead of a Microsoft account.

## -examples

## -see-also
