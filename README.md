# Sansomware
The totally harmless ransomware simulator for demo purposes

![Sansomware demo](demo.gif)

Sansomware is a small project built for demo purposes. Want to show your friends, colleagues or employees what ransomware looks like and how it works to improve awareness? You can use Sansomware to run on your local machine without really encrypting your files.

## How it works

As shown in the image above, Sansomware does the following things:
- It opens a popup window in WanaCry style with a note, a countdown timer and a random BitCoin-like address
- The wallpaper of the system is changed to a super hackery wallpaper
- Files in the same directory as where you place the file will have their extensions changed to .sansom, so put it in a demo folder

## Possible tweaks

The text of the note is saved in `Properties/note.txt` and can be adjusted to something else without touching the code. Same for `Properties/wallpaper.bmp`.

## Please note

It's harmless, it does not encrypt your files. As it changes the extension of the files only, please be aware that running the program from your Documents folder might harm your personal files. Only manual renaming will return your original files. Creating a demo folder with dummy files or a separate VM is recommended. Use at your own risk.
