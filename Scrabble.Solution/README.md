# Scrabble
##### By Adam Titus and James Osborn

### Details
Takes a word from the user and will tell them the Scrabble score for it with no board modifiers.

### Installation Instructions
* Copy the url for this repository
* Open your Shell program of choice, such as git bash or Terminal.
* Navigate with your shell to the location you would like to save this project.
* Once there, type the command `git clone` then paste the url you copied and hit enter.
* Now navigate to this folder that you cloned by typing `cd Scrabble`.
* Once in, type in your shell `dotnet restore` and wait for the files to be decompressed and loaded.
* Once finished, type `dotnet run`.
* Open web browser and navigate to `http://localhost:5000/`

### Technology Required
* .net
* Code Text Editor
* Shell program like gitbash or terminal
* Browser with internet
* GitHub

# Specs
|Behavior|Input|Output|
|-|-|-|
|Will take a word from the user and submit it via a form.|xylophone|displays xylophone again|
|Will not allow special characters or numbers to be entered. | $#$#$44 | Enter only one word! |
|Will split the word in to individual letters. | xylophone | x-y-l-o-p-h-o-n-e|
|Will assign the first letter a value. | x | 8 |
|Will assign the rest of letters of the word a value. | ylophone | 41134111 |
|Will add the letter scores together in to a word score. | xylophone | 24 |
| Will return the word score and display to user. | 24 | Word score: 24! |
| Will limit the user to entering one word. | The word | Enter only one word! |

### Contact Information
You can reach us at adamtitus76@gmail.com / jamescarlosborn@gmail.com or connect with Adam on linkedin at [www.linkedin.com/in/adam-titus-06740b149](www.linkedin.com/in/adam-titus-06740b149)


#### Legal
Licensed under the MIT License

Copyright (c) 2017 Adam Titus, James Osborn All Rights Reserved.

_If you find a way to monetize this please contact the authors_
