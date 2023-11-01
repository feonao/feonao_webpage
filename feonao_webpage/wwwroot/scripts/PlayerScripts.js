function ChangePlayerState() {
    var player;

    player = document.getElementById('audioPlayer');

    if (player.paused) {
        player.play();
    }
    else {
        player.pause();
    }
}

function SetAutoPlay(isEnabled) {
    var player;

    player = document.getElementById('audioPlayer');

    player.autoplay = isEnabled;
}

function SetSrc(path) {
    var player;

    player = document.getElementById('audioPlayer');

    if (player !== null) {
        player.src = path;
        player.preload = 'metadata';
    }
}