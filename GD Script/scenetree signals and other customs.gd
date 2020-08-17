#Making a connection with any node

func _ready():
	$YourNodeHere/IncludingPath.connect("game_over", self, "on_game_over") #self can be replaced with any node

emit_signal("game_over", score, health) #passing info just like a function

func on_game_over(score, health):
	print("health was " + health as String)
	print("score was " + score as String)

#Making a connection to SceneTree

func _ready()
	get_tree().connect("screen_resized", self, "_on_SceneTree_screen_resized")

func _on_SceneTree_screen_resized():
	print("You resized the window!")
