#Using keymaps:

func _unhandled_input(event):
	if Input.is_action_pressed("ui_accept"):

#Using specific keys on a keyboard
#This is not reccomended, with the exception of keyboard-driven desktop applications

func _input(event):
	if event is InputEventKey and event.pressed:
		if event.scancode == KEY_BRACELEFT:
