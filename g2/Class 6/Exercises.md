# Exercises
## Exercise 01
Create a method called NumberStats that accepts a number. This method should:
* Find out if the number is negative or positive
* Find out if the number is odd or even
* Find out if the number is decimal or integer
* After finding all the stats it should print them like this:

**Stats for number: 25**

**Positive**

**Integer**

**Odd**

The number should be entered in the console by the user.

**Bonus**: Validate if the user is entering a number

**Bonus**: Ask the user to press Y to try again or X to exit

## Exercise 02
Create a class User with the following:
* Id - int
* Username - string
* Password - string
* Messages - Array of strings
Create an array of users and add 3 users to it manually ( hard-coded ).

Create a Console UI that will ask the user:

1) Log in - When selected the user should be asked for username and password. If the user is found print welcome message and the messages that the user has in the Messages property:
**Welcome NAME. Here are your messages:**

**Message1**

**Message2**

If not found, it should print an error message

2) Register - When selected the user should be asked to enter ID, Username and password. It should then check if a there is already a username in the array of users like that. If there is, print a message that there is already a user called like that. If not, create a new user object from the information given in the console and add it to the Users array. Then print all the users by Id and Username
**Registration complete! Users:**

**23 Username1**

**44 Username2**

**1 Username3**

**56 Username4**


## Exercise 03

You will create a quiz!!

You will need a Question and Answer classes

The Question class will contain an array of Answers as a property and the question content
The Answer class will contain a boolean value for the answer truthfulness and its content

Then you will need to create the quiz where the questions are asked one by one and possible answers for that question are provided

The answers should be by choice i.e.

    What color is the color red?
        1) Red
        2) Blue
        3) Green
        4) Yellow
        
And one of the given numbers / selectors should be inputted in the console

If the user picks the wrong/right answer a corresponding message should be shown and the app should move to the next question.


**BONUS** - Create the questions and answers from keyboard input

**BONUS** - Add a point system

**BONUS** - Add a leader board (with different users and their points)

Don't worry you will not need to invent the questions and answers, they will be given to you
But as they are for C# the truthfulness of the answers is left on you  :)