/// @description Basic loop
// * Calculate the elapsed time (seconds.milliseconds)
if (state != 2) elapsedTime += delta_time / 1000000
// * Source for timer below: https://www.reddit.com/r/gamemaker/comments/3qiuwk/comment/cwflnv3/?utm_source=share&utm_medium=web2x&context=3
var difficulty = OBJ_DIFFICULTY.difficulty == 0 ? 4 : 5;
var spawnSpeed = OBJ_DIFFICULTY.difficulty == 0 ? 4 : 5.5;
var rng = 0;
if (OBJ_MANAGER.state == 2) return;
if (tick >= -1)
{
	// * Can't be arsed with making a better random system, not in this engine lol.
	rng = int64(random_range(0, 500));
	if (rng == 495) instance_create_depth(random_range(-room_width, room_width), 0, -10000, OBJ_APPLE);
	if (tick >= room_speed / spawnSpeed)
	{
		for (var i = 0; i < difficulty; i++) 
			instance_create_depth(random_range(-room_width, room_width), 0, -10000, OBJ_SPIKE);
		tick = 0;
	} else tick++;
}