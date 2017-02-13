---
-api-id: M:Windows.ApplicationModel.Resources.Core.ResourceContext.SetGlobalQualifierValue(System.String,System.String,Windows.ApplicationModel.Resources.Core.ResourceQualifierPersistence)
-api-type: winrt method
---

<!-- Method syntax
public void SetGlobalQualifierValue(System.String key, System.String value, Windows.ApplicationModel.Resources.Core.ResourceQualifierPersistence persistence)
-->

# Windows.ApplicationModel.Resources.Core.ResourceContext.SetGlobalQualifierValue

## -description
Applies a single qualifier value override to default contexts of all views for the current app, and specifies the persistence of the override.

## -parameters
### -param key
The name of the qualifier to override.

### -param value
The override value to set.

### -param persistence
The persistence of the override value.

## -remarks
This method fails with an exception if *key* or *value* are invalid.

## -examples

## -see-also
[SetGlobalQualifierValue(String, String)](resourcecontext_setglobalqualifiervalue.md)