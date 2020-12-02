---
-api-id: T:Windows.ApplicationModel.Contacts.ContactDate
-api-type: winrt class
---

<!-- Class syntax.
public class ContactDate : Windows.ApplicationModel.Contacts.IContactDate
-->

# Windows.ApplicationModel.Contacts.ContactDate

## -description
Represents an important date for a contact.

## -remarks

Here is how to use the ContactDate properties to format date strings.

### Insert sentinel values

1. Construct a [Windows.Globalization.Calendar](../windows.globalization/calendar.md).
1. If year has a value, set year to that value, else set year to 2004 (a leap year so every day is valid).
1. If month has a value, set month to that value, else set month to 1 (a month with every day valid).
1. If day has a value, set day to that value (day will be set to some value automatically and we don't really care what it is so no need to explicitly set it).
1. Get the [Windows.Foundation.DateTime](../windows.foundation/datetime.md) from the Calendar.

### Build up a template to format

1. If year has a value, append "year " to the template.
1. If month has a value, append "month " to the template.
1. If day has a value, append "day " to the template.
1. Construct a [Windows.Globalization.DateTimeFormatting.DateTimeFormatter](../windows.globalization.datetimeformatting/datetimeformatter.md) with the template.
1. Format by using the date time formatter and the [Windows.Foundation.DateTime](../windows.foundation/datetime.md) retrieved from the Calendar.


## -examples

## -see-also
[ImportantDates](contact_importantdates.md)
## -capabilities
contactsSystem
