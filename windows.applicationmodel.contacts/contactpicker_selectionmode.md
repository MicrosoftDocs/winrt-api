---
-api-id: P:Windows.ApplicationModel.Contacts.ContactPicker.SelectionMode
-api-type: winrt property
---

<!-- Property syntax
public Windows.ApplicationModel.Contacts.ContactSelectionMode SelectionMode { get;  set; }
-->

# Windows.ApplicationModel.Contacts.ContactPicker.SelectionMode

## -description
Controls whether the Contact Picker shows contacts as a complete entity or as a collection of fields.

> [!NOTE]
> This property is no longer available starting with Windows 10.

## -property-value
The mode for the Contact Picker user interface. You can set this to **Contacts** or **Fields**.

## -remarks
A contact can contain a lot of information. If you want all of this information, set the [SelectionMode](contactpicker_selectionmode.md) property to return the entire contact. If you are only interested in specific fields, set this property to return only a selection of fields, then use the [DesiredFields](contactpicker_desiredfields.md) property to specify which fields you want.

Use the [ContactSelectionMode](contactselectionmode.md) enumeration to set the value of this property.

## -examples

## -see-also
