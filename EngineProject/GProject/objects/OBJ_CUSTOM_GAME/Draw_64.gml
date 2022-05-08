/// @description Called whenever the start rooms gui is being drawn.
var rx = room_width / 2 + 20;
var ry = 40;
draw_set_halign(fa_center);
draw_set_valign(fa_middle);
 draw_text(rx, ry, "Difficulty: "  + string(OBJ_DIFFICULTY.difficulty));