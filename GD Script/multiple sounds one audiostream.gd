func play_sound(player : AudioStreamPlayer, sfx : AudioStream):
    player.stream = sfx
    player.play()