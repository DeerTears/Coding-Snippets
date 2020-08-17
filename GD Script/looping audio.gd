#Repeatedly playing AudioStreamPlayer2Ds with a WAV file that has loop info either causes weird noises or plays as if it started at the end before actually play from the beginning.
#Using AudioStreamPlayer2D.seek before playing makes the sound play from start, quickly stopping and quickly restarting like it was a small audio hickup.
#Before playing the audio, seek it to 0.0 and then play it starting from -1.0
$AudioStreamPlayer2D.seek(0.0) $AudioStreamPlayer2D.play(-1.0)

#Interally as far as I got it by reading the source code, when you play it from a value bellow 0.0, it'll skip some stuff on _mix_audio method, so seeking before playing it at -1 will make sure things are alright internally so it can skip that small code block and play normally.
#Playing at -1 before seeking won't actually play the audio at all.