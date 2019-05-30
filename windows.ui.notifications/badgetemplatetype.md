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
A system-provided glyph image. For more information, see [Badge overview](https://docs.microsoft.com/previous-versions/windows/apps/hh779719(v=win.10)).

### -field BadgeNumber:1
A numerical value from 1 to 99. Values greater than 99 are accepted, but in those cases "99+" is displayed instead of the actual number. In scenarios where your numbers are expected to be greater than 99, you should consider using a glyph instead.


## -remarks

## -examples

## -see-also
[App tiles and badges sample](https://go.microsoft.com/fwlink/p/?linkid=231469), [Guidelines and checklist for tiles and badges](https://docs.microsoft.com/windows/uwp/controls-and-patterns/tiles-and-notifications-creating-tiles), [How to clear a badge](https://docs.microsoft.com/previous-versions/windows/apps/hh700418(v=win.10)), [How to send a glyph or numeric badge in a local notification](https://docs.microsoft.com/previous-versions/windows/apps/hh700418(v=win.10)), [How to set up periodic notifications for badges](https://docs.microsoft.com/previous-versions/windows/apps/hh761476(v=win.10)), [How to update a badge through push notifications](https://docs.microsoft.com/previous-versions/windows/apps/hh465450(v=win.10)), [Badge XML schema](https://docs.microsoft.com/uwp/schemas/tiles/badgeschema/schema-root), [Badge overview](https://docs.microsoft.com/previous-versions/windows/apps/hh779719(v=win.10))
