---
-api-id: P:Windows.ApplicationModel.Contacts.Contact.YomiDisplayName
-api-type: winrt property
---

<!-- Property syntax
public string YomiDisplayName { get; }
-->

# Windows.ApplicationModel.Contacts.Contact.YomiDisplayName

## -description
Gets the Yomi (phonetic Japanese equivalent) display name for a contact.

## -property-value
The Yomi display name for a contact.

## -remarks
Windows calculates the [YomiDisplayName](contact_yomidisplayname.md) property by using the values from the [YomiGivenName](contact_yomigivenname.md) and [YomiFamilyName](contact_yomifamilyname.md) properties. The calculation for [YomiDisplayName](contact_yomidisplayname.md) takes into account different locale hints such as script of the text in the names, resource context, and default user locale to determine the proper formatting template for the name.

## -examples

## -see-also

## -capabilities
contactsSystem
