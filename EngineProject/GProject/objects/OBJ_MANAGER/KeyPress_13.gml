/// @description Called whenever the ENTER key has been pressed.
// * Check the state and verify that it's correct.
if (state != 2) return;
game_restart();
room_goto(R_MAIN); // Temporary