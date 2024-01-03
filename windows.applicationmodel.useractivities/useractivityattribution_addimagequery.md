---
-api-id: P:Windows.ApplicationModel.UserActivities.UserActivityAttribution.AddImageQuery
-api-type: winrt property
---

<!-- Property syntax.
public bool AddImageQuery { get;  set; }
-->

# Windows.ApplicationModel.UserActivities.UserActivityAttribution.AddImageQuery

## -description

Get or set whether to allow Windows to append a query string to the image URI supplied from [IconUri](useractivityattribution_iconuri.md) when retrieving the image. The query string includes information that can be used to choose the ideal image based on the DPI of the display, the high contrast setting, and the user's language.

## -property-value

`true` to allow windows to append a query string to the image URI; `false` otherwise.

## -remarks

Set to `true` if your server hosts images and can handle query strings, either by retrieving an image variant based on the query strings or by ignoring the query string and returning the image as specified without the query string. This query string specifies scale, contrast setting, and language; for instance, an **IconUri** value of `www.website.com/images/hello.png` becomes `www.website.com/images/hello.png?ms-scale=100&ms-contrast=standard&ms-lang=en-us`.

## -see-also

## -examples
