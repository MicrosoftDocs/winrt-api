---
-api-id: M:Windows.ApplicationModel.UserActivities.UserActivity.ToJson
-api-type: winrt method
---

<!-- Method syntax.
public string UserActivity.ToJson()
-->

# Windows.ApplicationModel.UserActivities.UserActivity.ToJson

## -description
Serializes the [UserActivity](useractivity.md) into a JSON string. Among other things, the JSON string will contain the App display name, the activation URL, the content URL, content information, and visual element information such as description, background color, and so on.

## -returns
The JSON text representation of the **UserActivity**.

## -remarks
A better re-engagement UI can be built within a consuming application if the source application can provide more details about the re-engagement. By serializing the **UserActivity** into a JSON string, you can then store it in a  [DataPackage](/uwp/api/windows.applicationmodel.datatransfer.datapackage) and reconstitute it in the consuming application to provide more insight about the source application and the specific activity within the application that sourced the **DataPackage**.

## -see-also
[UserActivity.ToJsonArray](useractivity_tojsonarray_543935915.md), [UserActivity.TryParseFromJson](useractivity_tryparsefromjson_986433327.md)

## -examples
