/// @description Prevent spawning inside other objects.
while (place_meeting(x, y, OBJ_SPIKE))
{
	x = random(room_width)
	y = random(5)
}
