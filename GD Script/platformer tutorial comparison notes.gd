#ACTOR.GD

extends KinematicBody2D
class_name Actor

const FLOOR_NORMAL = Vector2.UP

export var speed: = Vector2(300.0,1000.0)
export var gravity: = 500.0

var velocity: = Vector2.ZERO #start with no velocity

#PLAYER.GD

extends Actor #this calls upon the actor.gd script we wrote earlier because we defined the class_name as Actor in actor.gd

var direction: = Vector2.ZERO

func _physics_process(delta: float) -> void:
	var direction: = get_direction() #returns a Vector 2
	velocity = calc_move_velo(velocity, direction, speed)
	velocity = move_and_slide(velocity, FLOOR_NORMAL)

func get_direction() -> Vector2:
	return Vector2(
		Input.get_action_strength("ui_right") -
		Input.get_action_strength("ui_left"),
		-1.0 if Input.is_action_just_pressed("ui_accept")
		and is_on_floor() else 0.0
	)

func calc_move_velo(
		linear_velocity: Vector2,
		speed: Vector2,
		direction: Vector2
	) -> Vector2:
	var new_velocity: = linear_velocity
	new_velocity.x = speed.x * direction.x
	new_velocity.y += gravity * get_physics_process_delta_time()
	if direction.y == 1.0:
		new_velocity.y = speed.y * direction.y
	return new_velocity