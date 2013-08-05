

function searchYoutube(searchText) {
    $.ajax({
        type: 'POST',
        url: 'Search/Results',
        data: { searchText: searchText },
        success: function (data) {
            $('#SearchResults').html(data);
        }
    });
}

function queueVideo(videoId, videoTitle) {
    $.ajax({
        type: 'POST',
        url: 'Queue/QueueSong',
        data: { videoId: videoId, videoTitle: videoTitle },
        success: function (data) {
            $('#Queue').html(data);
        }
    });
}