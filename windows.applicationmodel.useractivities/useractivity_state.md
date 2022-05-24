---
-api-id: P:Windows.ApplicationModel.UserActivities.UserActivity.State
-api-type: winrt property
---

<!-- Property syntax.
public UserActivityState State { get; }
-->

# Windows.ApplicationModel.UserActivities.UserActivity.State

## -description

Gets the state (**Published** or **New**) of this **UserActivity**.

## -property-value

The state of this **UserActivity**.

## -remarks

Knowing that a **UserActivity** is **New** versus **Published** can be used to determine whether [GetOrCreateUserActivityAsync()](useractivitychannel_getorcreateuseractivityasync_1939478900.md) returned a newly created **UserActivity** or one that had been previously created.

## -see-also

## -examples

```cs
UserActivity userActivity = await channel.GetOrCreateUserActivityAsync(activityId);

//if it's a new UserActivity associate metadata with it
if (userActivity.State == UserActivityState.New)
{
    //required fields, SaveAsync() throws ArgumentNullException if not set
    userActivity.ActivationUri = new Uri("rss-reader:article?" + article.Link);
    userActivity.DisplayText = article.Title; //used for details tile text

    //optional fields
    userActivity.FallbackUri = article.Link;

    //we don't have a website for the app, but the article can be viewed in a browser
    userActivity.ContentUri = article.Link;

    userActivity.VisualElements.Description = article.Summary; //optional

    userActivity.ContentInfo = UserActivityContentInfo.FromJson(
        @"{
        ""@context"": ""http://schema.org"",
        ""@type"": ""Article"",
        ""author"": ""John Doe"",
        ""name"": ""How to Tie a Reef Knot""
        }");
    await userActivity.SaveAsync();
}
```
