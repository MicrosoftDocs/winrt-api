---
-api-id: P:Windows.ApplicationModel.Contacts.Contact.DisplayName
-api-type: winrt property
---

<!-- Property syntax
public string DisplayName { get; }
-->

# Windows.ApplicationModel.Contacts.Contact.DisplayName

## -description
Gets the display name for a contact.

## -property-value
The display name for a contact.

## -remarks

> [!NOTE]
> You can only access this property from a UI thread.

Windows calculates the DisplayName property by using the values from the [FirstName](contact_firstname.md), [MiddleName](contact_middlename.md), and [LastName](contact_lastname.md) properties if any are specified. If these values aren't available, Windows uses the Yomi (phonetic Japanese equivalent) name values ([YomiGivenName](contact_yomigivenname.md) and [YomiFamilyName](contact_yomifamilyname.md)). The calculation for DisplayName takes into account different locale hints such as script of the text in the names, resource context, and default user locale to determine the proper formatting template for the name.

## -examples

## -see-also

## -capabilities
contactsSystem
