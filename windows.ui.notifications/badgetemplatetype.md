---
-api-id: T:Windows.UI.Notifications.BadgeTemplateType
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Notifications.BadgeTemplateType : int
-->

# BadgeTemplateType

## -description
Specifies the template to use for a tile's badge overlay. Used by [BadgeUpdateManager.getTemplateContent](badgeupdatemanager_gettemplatecontent.md).

## -enum-fields
### -field BadgeGlyph:0
A system-provided glyph image. For more information, see [Badge overview](http://msdn.microsoft.com/library/a64c58bb-d9c9-4c09-a685-4df94fa7dfdd).

### -field BadgeNumber:1
A numerical value from 1 to 99. Values greater than 99 are accepted, but in those cases "99+" is displayed instead of the actual number. In scenarios where your numbers are expected to be greater than 99, you should consider using a glyph instead.


## -remarks

## -examples

## -see-also
[App tiles and badges sample](http://go.microsoft.com/fwlink/p/?linkid=231469), [Guidelines and checklist for tiles and badges](http://msdn.microsoft.com/library/e825f754-97dd-41c2-aff4-4dfb60eda677), [How to clear a badge](XREF:TODO:m_ui_tiles.howto_clear_a_badge), [How to send a glyph or numeric badge in a local notification](XREF:TODO:m_ui_tiles.howto_send_local_badge_notifications), [How to set up periodic notifications for badges](XREF:TODO:m_ui_tiles.howto_setup_badge_polling), [How to update a badge through push notifications](XREF:TODO:m_ui_tiles.howto_update_badges_push), [Badge XML schema](XREF:TODO:badge.Schema_Root), [Badge overview](http://msdn.microsoft.com/library/a64c58bb-d9c9-4c09-a685-4df94fa7dfdd)