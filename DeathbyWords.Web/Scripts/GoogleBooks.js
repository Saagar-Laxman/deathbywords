$(document).ready(function() {
   getVolumeCountForRECBookShelf(1003, renderVolumeCount)
    
});


function getVolumeCountForRECBookShelf(id, successMethod) {
    var url = 'https://www.googleapis.com/books/v1/users/113841492758204245298/bookshelves/' + id;
    
    $.getJSON(url, successMethod, onError);
}

function renderVolumeCount(data) {
    
}

function onError(e) {
    
}

