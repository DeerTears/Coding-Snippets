extends Node

var Visibility = $Node/Panel.Visibility.Modulate
var disappear = false

func _ready():
	Visibility = (0, 0, 0, 1)

func _delta():
	if Visibility != (0, 0, 0, 0):
		if disappear == true:
			Visibility -= (0, 0, 0, .01)

