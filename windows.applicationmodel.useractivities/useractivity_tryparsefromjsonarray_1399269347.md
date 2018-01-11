---
-api-id: M:Windows.ApplicationModel.UserActivities.UserActivity.TryParseFromJsonArray(System.String)
-api-type: winrt method
---

<!-- Method syntax.
public IVector<UserActivity> UserActivity.TryParseFromJsonArray(String json)
-->

# Windows.ApplicationModel.UserActivities.UserActivity.TryParseFromJsonArray

## -description
Creates a collection of [UserActivity](useractivity.md) objects from a JSON string.

## -parameters
### -param json
The JSON string that represents a collection of **UserActivity** objects.

## -returns
A collection of **UserActivity** objects.

## -remarks
The **UserActivity** APIs allow an application to provide rich information for Cortana Pick-up Where I Left Off and the Timeline. A better re-engagement UI can be built within the consuming  application if the source application can provide more details about the re-engagement. This method creates a collection of **UserActivity** objects from information stored in a JSON string that a source application provided so that the consuming application can get information about the source application, and the specific activities within the source application.

## -see-also
[UserActivity.ToJsonArray](useractivity_tojsonarray_543935915.md)

## -examples
