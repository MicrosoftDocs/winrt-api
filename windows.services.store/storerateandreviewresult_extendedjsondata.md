---
-api-id: P:Windows.Services.Store.StoreRateAndReviewResult.ExtendedJsonData
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public string ExtendedJsonData { get; }
-->

# Windows.Services.Store.StoreRateAndReviewResult.ExtendedJsonData

## -description
Gets the complete result data for a rate and review request in JSON format. This includes information to determine if a user aborted the dialog and error details if the call was not successful.

## -property-value
A JSON-formatted string that contains the result from a rate and review request.

## -remarks
Use the **ExtendedJsonData** property to access the complete data for the [StoreRateAndReviewResult](storerateandreviewresult.md) object as a JSON-formatted string in your code.

JSON Schema:

{
    "type": "object",
    "properties": {
        "status": {
            "enum": [ "success", "aborted" ]
        },
        "data": {
            "type": "object",
            "properties": {
                "updated": {
                    "type": "boolean"
                }
            },
            "required": [
                "updated"
            ]
        },
        "errorDetails": {
            "type": "string"
        }
    },
    "required": [
        "status",
        "errorDetails"
    ]
}

## -see-also
[RequestRateAndReviewAppAsync](storecontext_requestrateandreviewappasync_2001521545.md),[StoreRateAndReviewResult](storerateandreviewresult.md)

## -examples
