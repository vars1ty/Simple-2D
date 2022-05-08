/// @description Invoked whenever the LEFT Mouse Button has been pressed.
show_debug_message("moving scenes");
// * Change the difficulty to '1' (Medium)
OBJ_DIFFICULTY.difficulty = 5;
// * Switch rooms
room_goto(R_MAIN);
