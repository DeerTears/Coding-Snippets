extends Control

func _ready():
    $OS_Label.text = "OS: " + OS.get_name()
    $Engine_Label.text = "Godot version: " + Engine.get_version_info()["string"]

func _process(delta):
    $FPS_Label.text = "FPS: " + str(Engine.get_frames_per_second())
    
//this for an fps couner with the label FPS_Label
//this is also to get godot version/os into labels named OS_Label and Engine_Label respectively
