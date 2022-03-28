/// @description Called for every frame the GUI is being drawn
var rx = room_width / 2;
var ry = 40;
// * Center the text
if (state >= 0) draw_set_halign(fa_center);
// * Draw text depending on the state
switch (state)
{
	case 0:
	  // ! Skip, no logic needed
	case 1:
	  // * Active
	  // ? Set the text color to white
	  draw_set_color(c_white);
	  // ? Draw the text
	  draw_text(rx, ry, string(elapsedTime) + "\nBest Recorded: " + string(OBJ_MANAGER.bestScore));
    break;
	case 2:
	  // * Dead
	  draw_set_color(c_red);
	  draw_text(rx, ry, "You timed " + string(elapsedTime) + "s, congrats!\nPress ENTER to continue.");
	  // TODO: Add high-score checks here (Issue #8)
	break;
}