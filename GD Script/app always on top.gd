on_top = false

func settings():
	if on_top:
		on_top = false
		OS.set_window_always_on_top(false)
		print("ALWAYS ON TOP: FALSE")
	else:
		on_top = true
		OS.set_window_always_on_top(true)
		print("ALWAYS ON TOP: TRUE")
