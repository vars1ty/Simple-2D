/// @description Basic loop
// * Calculate the elapsed time (seconds.milliseconds)
if (state != 2) elapsedTime += delta_time / 1000000
// * Source for timer below: https://www.reddit.com/r/gamemaker/comments/3qiuwk/comment/cwflnv3/?utm_source=share&utm_medium=web2x&context=3
var difficulty = OBJ_DIFFICULTY.difficulty == 0 ? 2 : 3;
var spawnSpeed = OBJ_DIFFICULTY.difficulty == 0 ? 2 : 2.5;
if (OBJ_MANAGER.state == 2) return;
if (tick >= -1)
{
	if (tick >= room_speed / spawnSpeed)
	{
		for (var i = 0; i < difficulty; i++) 
			instance_create_depth(OBJ_DUMMY_PLAYER.x + random_range(-5, 5), 0, -10000, OBJ_SPIKE);
		tick = 0;
	} else tick++;
}