
// 2. This code loads the IFrame Player API code asynchronously.
var tag = document.createElement('script');

tag.src = "https://www.youtube.com/iframe_api";
var firstScriptTag = document.getElementsByTagName('script')[0];
firstScriptTag.parentNode.insertBefore(tag, firstScriptTag);

// 3. This function creates an <iframe> (and YouTube player)
//    after the API code downloads.
var player;
function onYouTubeIframeAPIReady() {
    player = new YT.Player('player', {
        height: '390',
        width: '640',
        videoId: 'DIGfO2Dgc9Y',
        origin: '',
        playerVars: { 'autoplay': 0, 'controls': 1 },
        events: {
        //'onReady': onPlayerReady
        'onStateChange': onPlayerStateChange                        
        }
        //u1zgFlCw8Aw
    });
}

// 4. The API will call this function when the video player is ready.
function onPlayerReady(event) {
    //event.target.playVideo();
}

// 5. The API calls this function when the player's state changes.
//    The function indicates that when playing a video (state=1),
//    the player should play for six seconds and then stop.
//var done = false;
function onPlayerStateChange(event) {
    if (event.data == YT.PlayerState.ENDED)
        playNextVideo();
}

function playNextVideo() {
    var videoId = "";
    var active = $(".active");
    
    if (active != null) {
        videoId = active.next().attr("id");

        if (videoId != null)
            playVideo(videoId);
    }
}


function refreshActiveVideo(videoId) {
    $("#Queue li").removeClass("active");
    $("#" + videoId).addClass("active");
}

function playVideo(videoId) {
    player.loadVideoById(videoId);
    refreshActiveVideo(videoId);
}


function stopVideo() {
    player.stopVideo();
}

function play() {
    player.playVideo();
}
    
function pause() {
    player.pauseVideo();
}
    
function skip() {
    player.nextVideo();
}