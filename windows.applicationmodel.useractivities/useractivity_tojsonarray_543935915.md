---
-api-id: M:Windows.ApplicationModel.UserActivities.UserActivity.ToJsonArray(Windows.Foundation.Collections.IIterable{Windows.ApplicationModel.UserActivities.UserActivity})
-api-type: winrt method
---

<!-- Method syntax.
public string UserActivity.ToJsonArray(IIterable<UserActivity> activities)
-->

# Windows.ApplicationModel.UserActivities.UserActivity.ToJsonArray

## -description
Serializes a collection of [UserActivity](useractivity.md) objects into a JSON string. Among other things, the JSON string will contain the App display name, the activation URL, the content URL, content information, and visual element information such as description, background color, and so on for each **UserActivity**.

## -parameters
### -param activities
The collection of user activities to convert to JSON.

## -returns
A JSON string representing the user activities.

## -remarks
A better re-engagement UI can be built within a consuming application if the source application can provide more details about the re-engagement. By serializing the collection of **UserActivity** objects into a JSON string, you can then store them in a  [DataPackage](/uwp/api/windows.applicationmodel.datatransfer.datapackage) and reconstitute them in the consuming application to provide more insight about the source application and the specific activities within the application that sourced the **DataPackage**.

## -see-also
[UserActivity.ToJson](useractivity_tojson_1289546151.md)
[UserActivity.TryParseFromJsonArray](useractivity_tryparsefromjsonarray_1399269347.md)

## -examples
