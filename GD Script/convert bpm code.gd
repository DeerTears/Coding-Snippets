func set_speed(bpm_speed):
	#Convert from bpm to miliseconds:
	var result = abs(1 / (float(bpm_speed)/60))
	#Make sure the speed is not zero. Godot does not like it:
	if bpm_speed == 0:
		bpm_speed = 1
		
	return result

func set_speed2(milliseconds):  
	var result = int(60/milliseconds)
	
	return result
##################################################

#	loop_timer.connect("timeout", self, "repeat")
