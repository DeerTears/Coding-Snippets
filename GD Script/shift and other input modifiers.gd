#old bad code for modifiers specifically

extends Node

func _unhandled_input(event):
	if Input.is_action_pressed("ui_accept"):
		print("enter pressed!")
	if Input.is_action_pressed("ui_up"):
		if Input.is_action_pressed("ui_shift"):
			print("shift + up pressed!")
		else:
			print("up pressed!")
	elif Input.is_action_pressed("ui_down"):
		if Input.is_action_pressed("ui_shift"):
			print("shift + down pressed!")
		else:
			print("down pressed!")

#good new code is a 2 step process, one to initialise the combo in _ready(), the other to utilise it in _unhandled_input(event)

func _ready():
	InputMap.add_action("fancy_action")
	var key : InputEventKey = InputEventKey.new()
	key.scancode = KEY_UP
	key.shift = true
	InputMap.action_add_event("fancy_action", key )

func _unhandled_input(event):
	if event.is_action_pressed("fancy_action"):
		print("shift + up were pressed!")
		
#now event.is_action_pressed("fancy_action") will only occur if you press Shift + Up
#the same thing can be done with key.alt, key.command, key.control, and key.meta

