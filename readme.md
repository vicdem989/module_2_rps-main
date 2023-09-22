For this assignment I wanted to make the specific parts in a separate C# file. This allow for greater reausability in future assignments.
The startEndSCreen file I was considering breaking that into startScreen and endSCreen, two separate files. But, for this project I didn't feel the need. 

For the ANSI escape code I made a separate utilites file, allowing for a wide array of ANSI escape codes whenever I wanted. Therefore, a lot of them is also not in use. 
But is easy to access in later projects if I want to. The comments is to easily clarify which string block does what. 

The custom feature I implemented isn't anything new or original. First I made it bo3, which there are some resemblance from in the code. 
Later I decided to turn the bo3 into boX, allowing for a customizable amonut of rounds to be played. There is also a check that if the user inputs rounds < 15 then they have to confirm the amount of rounds. Here I managed to introduce a slight bug, it doesn't reset the amount of rounds after the first check.

The biggest issue I kept running into is writing inefficient code. Yes, this is something that I will improve upon over time. But, I also feel it's my current biggest downfall.

I could also have added a file called languages, where all the different languages would go into. Therefore, if I wanted to add more languages, they would be neatly organized.