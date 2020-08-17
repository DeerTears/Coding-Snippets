1000ms = 1 second
60 000 ms per minute / beat per minute = one beat in milliseconds

Space between two beats at:
bpm, milliseconds
120, 500
110, 545
100, 600
90, 667
80, 750
70, 857
60, 1000
50, 1200
40, 1500
30, 2000

enum{
res://Sounds/120bpm.wav = 120
res://Sounds/130bpm.wav = 130
res://Sounds/140bpm.wav = 140
res://Sounds/150bpm.wav = 150
res://Sounds/160bpm.wav = 160
res://Sounds/170bpm.wav = 170
res://Sounds/180bpm.wav = 180
res://Sounds/190bpm.wav = 190
res://Sounds/200bpm.wav = 200
res://Sounds/210bpm.wav = 210
res://Sounds/220bpm.wav = 220
res://Sounds/230bpm.wav = 230
res://Sounds/240bpm.wav = 240
res://Sounds/250bpm.wav = 250
}

func play(int)
	
_on_Metro_timeout():
	if BPM < 120:
		ms = 60000/BPM
		Metro_time = ms - audio_latency
		$Metro.start()
else:
	upper_ends()

func upper_ends():
	if BPM == 120:
		play(120, true)