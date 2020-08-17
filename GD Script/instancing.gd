var scene = load("res://ButtonInstance.tscn")

func _ready():
	var button = scene.instance()
	add_child(button)
