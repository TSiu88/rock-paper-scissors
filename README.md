# _Rock, Paper, Scissors_

#### _Brief desc of Project, 03.4.2020_

#### By _**Tiffany Siu and Andriy Veremyeyev**_

## Description

_README under construction_
<!-- _Detailed desc w/ purpose/usage, what does, motivation to create, why exists, other info for users/developers to have_ -->

## Setup/Installation Requirements

### Requirements to Run
#### C#
* _.NET Core_
* _Command Prompt_

### Instructions

*This page may be viewed by:*

1. Download and install .NET Core from the [official website](https://dotnet.microsoft.com/download/dotnet-core/)
2. Clone the [repository](https://github.com/TSiu88/rock-paper-scissors.git) from my [GitHub page](https://github.com/TSiu88)
3. Use a command line interface to move to the repository's directory with `cd project-directory`
4. Run `dotnet run` to start up the program in the command line interface 

## Other Technologies Used
#### C#
* _C#_
* _MSTest_
* _Markdown_

## Notable Features
<!-- _features that make project stand out_ -->

## Specifications

* _The program takes input from the user that is not one of the possible responses for the current question._
  * _Example Input: user types "Lizard"_
  * _Example Output: Output="Response not recognized, please choose one of the possible responses listed." and returns user to question_
* _The program asks if the user wants to play a game and the user types "No"._
  * _Example Input: user input="No"_
  * _Example Output: program exits_
* _The program asks if the user wants to play a game and the user types "Yes"_
  * _Example Input: user input="Yes"_
  * _Example Output: program continues and asks what kind of game to start_
* _The program asks if the user wants to play 2 player mode or against a computer and begins game with that many players._
  * _Example Input: user types "Computer"_
  * _Example Output: program asks for input on player 1's choice._
* _The program takes input from a user on what they've chosen out of Rock, Paper, or Scissors._
  * _Example Input: user types "Rock"_
  * _Example Output: Player response property saved as "Rock"_
* _The program chooses randomly between the three choices when playing against the computer._
  * _Example Input: user chooses to play against a computer_
  * _Example Output: Computer randomly chooses "Rock" from the possible choices_
* _The program compares inputs for players and gives output on who won. Rock wins vs Scissors, Paper wins vs Rock, and Scissors wins vs Paper._
  * _Example Input: Player1="Rock", Player2="Scissors"_
  * _Example Output: "Player1 Wins!"_
* _The program compares inputs for players and gives output when they are the same."_
  * _Example Input: Player1="Paper", Player2="Paper"
  * _Example Output: Output="Draw! Nobody wins."_


## Screenshots

<!-- _Here is a snippet of what the input looks like:_

![Snippet of input fields](img/snippet1.png)

_Here is a preview of what the output looks like:_

![Snippet of output box](img/snippet2.png) -->

<!-- _{Show pictures using ![alt text](image.jpg), show what library does as concisely as possible but don't need to explain how project solves problem from `code`_ -->

## Test Case Example
<!-- _Tests are done through Jest and are run from the command line prompt with `npm test`._
_Some example tests:_
![Snippet of an example test](img/test1.png)

![Snippet of an example result](img/test2.png) -->
<!-- _describe and show how to run tests with `code` examples}_ -->

## Known Bugs

_There are currently no known bugs in this program_

## Support and contact details

_If there are any question or concerns please contact me at my [email](mailto:tsiu88@gmail.com). Thank you._

### License

*This software is licensed under the MIT license*

Copyright (c) 2020 **_Tiffany Siu, Andriy Veremyeyev_**
