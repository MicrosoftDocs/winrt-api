---
-api-id: M:Windows.ApplicationModel.Background.BackgroundTaskRegistrationGroup.#ctor(System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax.
public BackgroundTaskRegistrationGroup.BackgroundTaskRegistrationGroup(String id, String name)
-->

# Windows.ApplicationModel.Background.BackgroundTaskRegistrationGroup.BackgroundTaskRegistrationGroup


## -description

Creates a **BackgroundTaskRegistrationGroup** with the specified group ID and

## -parameters

### -param id

The group ID.

### -param name

The friendly name for this group.

## -remarks

To reduce collisions with other group identifiers, consider including your domain name in the group ID. For example: `"com.contoso.appname.tasks"`. Or use the string form of a [GUID](/windows/win32/api/guiddef/ns-guiddef-guid).

The friendly name can be useful for debugging purposes if your group IDs are difficult to distinguish.

## -see-also

## -examples

