---
-api-id: M:Windows.ApplicationModel.UserActivities.UserActivity.TryParseFromJson(System.String)
-api-type: winrt method
---

<!-- Method syntax.
public UserActivity UserActivity.TryParseFromJson(String json)
-->

# Windows.ApplicationModel.UserActivities.UserActivity.TryParseFromJson

## -description
Constructs a [UserActivity](useractivity.md) from a JSON string.

## -parameters
### -param json
The JSON string that represents the **UserActivity**.

## -returns
A **UserActivity** constructed from the JSON string.

## -remarks
The **UserActivity** APIs allow an application to provide rich information for Cortana Pick-up Where I Left Off and the Timeline. A better re-engagement UI can be built within the consuming  application if the source application can provide more details about the re-engagement. This method creates a **UserActivity** from information stored in a JSON string that a source application provided so that the consuming application can get information about the source application, and the specific activity within the source application.

## -see-also
[UserActivity.ToJson](useractivity_tojson_1289546151.md)

## -examples
