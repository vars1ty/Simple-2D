/// @description Invoked whenever the LEFT Mouse Button has been pressed.
//if (OBJ_DIFFICULTY.difficulty <= .5) return;
show_debug_message("moving scenes, custom game difficulty : " + string(OBJ_DIFFICULTY.difficulty));
// * Switch rooms
room_goto(R_MAIN);