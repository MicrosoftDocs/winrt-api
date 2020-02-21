---
-api-id: M:Windows.ApplicationModel.Background.BackgroundTaskRegistrationGroup.#ctor(System.String)
-api-type: winrt method
---

<!-- Method syntax.
public BackgroundTaskRegistrationGroup.BackgroundTaskRegistrationGroup(String id)
-->

# Windows.ApplicationModel.Background.BackgroundTaskRegistrationGroup.BackgroundTaskRegistrationGroup


## -description

Creates a **BackgroundTaskRegistrationGroup** with the specified group ID.

## -parameters

### -param id

The group ID.

## -remarks

To reduce collisions with other group identifiers, consider including your domain name in the group identifier. For example: `"com.contoso.appname.tasks"`. Or use the string form of a [GUID](/windows/win32/api/guiddef/ns-guiddef-guid).

## -see-also

## -examples

