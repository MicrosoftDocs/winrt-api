---
-api-id: T:Windows.UI.Notifications.BadgeTemplateType
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.UI.Notifications.BadgeTemplateType : int
-->

# BadgeTemplateType

## -description
Specifies the template to use for a tile's badge overlay. Used by [BadgeUpdateManager.getTemplateContent](badgeupdatemanager_gettemplatecontent_2049200015.md).

## -enum-fields
### -field BadgeGlyph:0
A system-provided glyph image. For more information, see [Badge overview](https://msdn.microsoft.com/library/a64c58bb-d9c9-4c09-a685-4df94fa7dfdd).

### -field BadgeNumber:1
A numerical value from 1 to 99. Values greater than 99 are accepted, but in those cases "99+" is displayed instead of the actual number. In scenarios where your numbers are expected to be greater than 99, you should consider using a glyph instead.


## -remarks

## -examples

## -see-also
[App tiles and badges sample](https://go.microsoft.com/fwlink/p/?linkid=231469), [Guidelines and checklist for tiles and badges](https://msdn.microsoft.com/library/e825f754-97dd-41c2-aff4-4dfb60eda677), [How to clear a badge](https://msdn.microsoft.com/library/6b2d57e0-51aa-4bce-894e-fa3fd32d77bb), [How to send a glyph or numeric badge in a local notification](https://msdn.microsoft.com/library/6b2d57e0-51aa-4bce-894e-fa3fd32d77bb), [How to set up periodic notifications for badges](https://msdn.microsoft.com/library/96c67773-2e5b-4278-b16d-2f813b16580c), [How to update a badge through push notifications](https://msdn.microsoft.com/library/bb962e30-6c95-4186-8a0e-6683140e17c7), [Badge XML schema](https://docs.microsoft.com/uwp/schemas/tiles/badgeschema/schema-root), [Badge overview](https://msdn.microsoft.com/library/a64c58bb-d9c9-4c09-a685-4df94fa7dfdd)
