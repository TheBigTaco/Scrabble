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
