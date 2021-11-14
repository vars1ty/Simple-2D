/// @description Called for every frame the GUI is being drawn
var rx = room_width / 2;
var ry = 40;
// * Center the text
if (state >= 0) draw_set_halign(fa_center);
// * Draw text depending on the state
switch (state)
{
	case 0: // * Jump
	case 1:
	  draw_set_color(c_white);
	  draw_text(rx, ry, elapsedTime);
    break;
	case 2:
	  draw_set_color(c_red);
	  draw_text(rx, ry, "Nice, you timed " + string(elapsedTime) + "s!\nPress ENTER to continue");
	break;
}