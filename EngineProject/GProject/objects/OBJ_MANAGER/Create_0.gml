/// @description Change the state on startup to 1 ("Alive")
// * Available states:
// * 0 = Inactive
// * 1 = Alive
// * 2 = Dead
state = 1;
var file;
show_debug_message("Git Project: Simple-2D » https://github.com/qqtc0/Simple-2D/");
show_debug_message("Made by devin#0911");
// ! Check if the high-score file is present.
if (!file_exists(hsFile))
{
	file = file_text_open_write(hsFile);
	file_text_write_real(file, 0);
	file_text_close(file);
	return;
}

// * Highscore file is present, load the score.
var read = file_text_open_read(hsFile);
bestScore = file_text_read_real(read);
file_text_close(read);
