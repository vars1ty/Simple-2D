/// @description Called on the instances creation
// * Almost same as OBJ_CUBE::Create() - This is called whenever the object has been created and is active
// * Cache the start position so we can use it later
startX = x;
startY = y;
// * Print debug messages
show_debug_message(separator);
show_debug_message("OBJ_DUMMY_PLAYER [Player] active at " + string(x) + ", " + string(y));
show_debug_message(separator);