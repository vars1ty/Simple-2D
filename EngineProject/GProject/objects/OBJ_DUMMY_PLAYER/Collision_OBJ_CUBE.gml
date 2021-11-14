/// @description Called whenever the player collides with any "OBJ_CUBE" instance
// * Broader description:
// * As game_restart() doesn't find the keys being held down after called, it's just resetting the position of the player to the start position.
// * Performance-wise, this should also be faster as it doesn't have to refresh the assets.
x = startX;
y = startY;