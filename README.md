# Sansomware
The totally harmless ransomware simulator for demo purposes

![Sansomware demo](demo.gif)

Sansomware is a small project built for demo purposes. Want to show your friends, colleagues or employees what ransomware looks like and how it works? You can use Sansomware to run on your local machine without really encrypting your files. Use cases could be live hacking demos for example.

## How it works

As shown in the image above, Sansomware does the following things:
- It opens a popup window in WanaCry style with a note, a countdown timer and a ransom BitCoin-like address
- The wallpaper of the system is changed to a super hackery wallpaper
- Files in the same directory as the binary will have their extensions changed to .sansom

## Possible tweaks

The text of the note is saved in `Properties/note.txt` and can be adjusted to something else without changing the code. Same for `Properties/wallpaper.bmp`.

## Please note

It's really harmless. If you use this in other environments than security awareness sessions, profit is 0.
