function GetAudioPlayer() {
    var player = document.getElementById('audioPlayer');

    return player;
}

function ChangePlayerState() {
    var player = GetAudioPlayer();

    if (player.paused) {
        player.play();
    }
    else {
        player.pause();
    }
}

function SetAutoPlay(isEnabled) {
    var player = GetAudioPlayer();

    player.autoplay = isEnabled;
}

function SetSrc(path) {
    var player = GetAudioPlayer();

    if (player !== null) {
        player.src = path;
        player.preload = 'metadata';
    }
}