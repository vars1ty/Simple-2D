/// @description Invoked whenever the LEFT Mouse Button has been pressed.
show_debug_message("moving scenes");
// * Change the difficulty to '0' (Easy)
OBJ_DIFFICULTY.difficulty = 4;
// * Switch rooms
room_goto(R_MAIN);
