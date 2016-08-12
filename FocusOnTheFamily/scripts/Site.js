function ProcessSendAjax(data, endPoint)
{
    var isSuccess = false;

    $.ajax({
        url: endPoint,
        data: data,
        type: 'POST',
        async: false,
        success: function (data) {
            // check any responses here
            isSuccess = true;
            
        },
        error: function (xhr, ajaxOptions, thrownError) {
            alert("Error");
            alert(thrownError);
            console.log(xhr);
            console.log(ajaxOptions);
            console.log(thrownError);
            isSuccess = false;
        }
    });

    return isSuccess;
}

function ContentUpdateTitle(title, contentID)
{
    var data = {
        ContentID: $('#ContentID').val(),
        Title: $('#Title').val()
    };

    if(ProcessSendAjax(data, '/Admin/UpdateContentTitle/'))
    {
        alert("Updated!");
        location.reload(true);
    }
}

function DeleteStory(storyID)
{
    if(confirm("Are you sure you want to delete this story?"))
    {
        var data = { ContentSToryID: storyID };
        if (ProcessSendAjax(data, '/Admin/DeleteContentStory/'))
        {
            alert("Deleted!");
            location.reload(true);
        }
    }
}

function UpdateStory(contentID, storyID, storyTitle, storyText, imagePath, relatedProductID)
{
    if (confirm("Are you sure you want to update this story?"))
    {
        var data = {
            ContentID: contentID,
            ContentSToryID: storyID,
            StoryTitle: storyTitle,
            StoryText: storyText,
            ImagePath: imagePath,
            RelatedProductID: relatedProductID
        };

        if (ProcessSendAjax(data, '/Admin/UpdateContentStory/'))
        {
            alert("Updated!");
            location.reload(true);
        }
    }
}

function UpdateProduct() {
    if (confirm("Are you sure you want to update this Product?")) {
        var productData = {
            ProductID: $('#ProductID').val(),
            ISBN: $('#ISBN').val(),
            Title: $('#Title').val(),
            Summary: $('#Summary').val(),
            Description: $('#Description').val(),
            Price: $('#Price').val(),
            QtyAvail: $('#QtyAvail').val(),
            Authors: $('#Authors').val(),
            ImagePath: $('#ImagePath').val()
        };

        if (ProcessSendAjax(productData, '/Admin/UpdateProduct/')) {
            alert("Updated!");
            location.reload(true);
        }
    }
}

function UpdateProductDetail(productID, productDetailID, title, summary) {
    if (confirm("Are you sure you want to update the detail?")) {
        var data = {
            ProductDetailID: productDetailID,
            ProductID: productID,
            DetailTitle: title,
            DetailSummary: summary
        };

        if (ProcessSendAjax(data, '/Admin/UpdateProductDetail/')) {
            alert("Updated!");
            location.reload(true);
        }
    }
}

function DeleteProductDetail(productDetailID) {
    if (confirm("Are you sure you want to delete this detail?")) {
        var data = { ProductDetailID: productDetailID };

        if (ProcessSendAjax(data, '/Admin/DeleteProductDetail/')) {
            alert("Deleted!");
            location.reload(true);
        }
    }
}