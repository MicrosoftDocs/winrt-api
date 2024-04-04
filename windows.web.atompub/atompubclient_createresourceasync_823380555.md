---
-api-id: M:Windows.Web.AtomPub.AtomPubClient.CreateResourceAsync(Windows.Foundation.Uri,System.String,Windows.Web.Syndication.SyndicationItem)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<Windows.Web.Syndication.SyndicationItem, Windows.Web.Syndication.TransferProgress> CreateResourceAsync(Windows.Foundation.Uri uri, System.String description, Windows.Web.Syndication.SyndicationItem item)
-->

# Windows.Web.AtomPub.AtomPubClient.CreateResourceAsync

## -description
Creates a new Entry resource in the specified collection. The Uri of the collection in which to create the new resource can be discovered from the [ResourceCollection](resourcecollection.md) object retrieved from the [RetrieveResourceAsync](atompubclient_retrieveresourceasync_1946100714.md) method.

## -parameters
### -param uri
The Uri of the specified collection in which the new resource should be created.

### -param description
The description of the new resource that is turned into the Slug: header of the POST request.

### -param item
The new resource to be created.

## -returns
The object that is used to create the resource asynchronously and to report the progress and completion status of the operation.

## -remarks

## -examples
The following code demonstrates how to access a service document and retrieve edit URI values. For additional examples of how AtomPub can be used to manage feed content, download the [AtomPub sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/AtomPub%20sample).

```javascript
    function createResource() {
        try {
            // Refresh client in case server url or credential have changed.
            createClient();

            var title = document.getElementById("titleField").value;
            if (title === "") {
                outputField.innerHTML = "Post title cannot be blank";
                return;
            }

            var serviceUri = new Windows.Foundation.Uri(document.getElementById("serviceAddressField").value.trim() + defaultServiceDocUri);
            outputField.innerHTML = "Fetching service document: " + serviceUri.absoluteUri + "</br>";
            findEditUri(serviceUri).then(function (resourceUri) {
                if (!resourceUri) {
                    outputField.innerHTML += "Error: Edit uri not found in service document";
                    return null;
                }

                outputField.innerHTML += "Uploading post: " + resourceUri.absoluteUri + "</br>";

                var item = new Windows.Web.Syndication.SyndicationItem();
                item.title = new Windows.Web.Syndication.SyndicationText(title, Windows.Web.Syndication.SyndicationTextType.text);
                var content = document.getElementById("bodyField").value;
                item.content = new Windows.Web.Syndication.SyndicationContent(content, Windows.Web.Syndication.SyndicationTextType.html);

                return client.createResourceAsync(resourceUri, item.title.text, item);
            }).done(function (result) {
                if (result) {
                    outputField.innerHTML += "Posted at " + result.itemUri.absoluteUri + "</br>";
                    outputField.innerHTML += "Complete</br>";
                }
            }, onError);
        }
        catch (ex) {
            outputField.innerHTML += "Exception:" + ex + "</br>";
        }
    }
```

> [!NOTE]
> See [RetrieveServiceDocumentAsync](atompubclient_retrieveservicedocumentasync_1639649532.md) for the code behind the **findEditUri** function called in this example.

## -see-also
[Quickstart: Managing Feed Entries](/previous-versions/windows/apps/hh700368(v=win.10)), [AtomPub sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/AtomPub%20sample)
