/// @description Called whenever the spike collides with the player.
OBJ_MANAGER.state = 2;
var currentScore = OBJ_MANAGER.elapsedTime;
if (currentScore <= OBJ_MANAGER.bestScore) return; // ! <= The score was either lower or same as the current best score, therefore ignore it.
// Linux users: the config file is in ~/.config/GProject/* (nvim ~/.config/GProject/*)
var file = file_text_open_write(OBJ_MANAGER.hsFile);
OBJ_MANAGER.bestScore = currentScore;
file_text_write_real(file, currentScore);
file_text_close(file);
// \/ xd enjoy the easter egg lmao
if (currentScore >= 100) url_open("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
