---
-api-id: M:Windows.Web.AtomPub.AtomPubClient.RetrieveServiceDocumentAsync(Windows.Foundation.Uri)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<Windows.Web.AtomPub.ServiceDocument, Windows.Web.Syndication.RetrievalProgress> RetrieveServiceDocumentAsync(Windows.Foundation.Uri uri)
-->

# Windows.Web.AtomPub.AtomPubClient.RetrieveServiceDocumentAsync

## -description
Retrieves a service document from the specified Uri.

## -parameters
### -param uri
The specified Uri.

## -returns
The object that is used to retrieve the service document asynchronously and to report the progress and completion status of the operation.

## -remarks

## -examples
The following code demonstrates how to access a service document and retrieve edit URI values. For additional examples of how AtomPub can be used to manage feed content, download the [AtomPub sample](https://go.microsoft.com/fwlink/p/?linkid=245061).

```javascript

    function findEditUri(serviceUri) {
        return client.retrieveServiceDocumentAsync(serviceUri).then(function (serviceDocument) {
            for (var i in serviceDocument.workspaces) {
                var workspace = serviceDocument.workspaces[i];
                for (var j in workspace.collections) {
                    var collection = workspace.collections[j];

                    if (collection.accepts.join(";") === "application/atom+xml;type=entry") {
                        return collection.uri;
                    }
                }
            }

            return null;
        });
    }
```



## -see-also
[Quickstart: Managing Feed Entries](https://msdn.microsoft.com/library/239d42bc-5812-4ead-a91c-b3696fc3ef75), [AtomPub sample](https://go.microsoft.com/fwlink/p/?linkid=245061)
