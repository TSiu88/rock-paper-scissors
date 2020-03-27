# _Rock, Paper, Scissors_

#### _Play Rock, Paper, Scissors Game, 03.4.2020_

#### By _**Tiffany Siu and Andriy Veremyeyev**_

[![Project Status: Inactive – The project has reached a stable, usable state but is no longer being actively developed; support/maintenance will be provided as time allows.](https://www.repostatus.org/badges/latest/inactive.svg)](https://www.repostatus.org/#inactive)
![LastCommit](https://img.shields.io/github/last-commit/tsiu88/rock-paper-scissors)
![Languages](https://img.shields.io/github/languages/top/tsiu88/rock-paper-scissors)
[![MIT license](https://img.shields.io/badge/License-MIT-orange.svg)](https://lbesson.mit-license.org/)

---
## Table of Contents
1. [Description](#description)
2. [Setup/Installation Requirements](#setup/installation-requirements)
    - [Requirements to Run](#requirements-to-run)
    - [Instructions](#instructions)
    - [Other Technologies Used](#other-technologies-used)
3. [Specifications](#specifications)
4. [Known Bugs](#known-bugs)
5. [Support and Contact Details](#support-and-contact-details)
6. [License](#license)
---

## Description

This console application was written for Epicodus Intro to Programming and C#/React course.  This program allows rock, paper, scissors to be played against a computer or another person.  Choices would be typed into the console and the after the winner will be announced by the program.

## Setup/Installation Requirements
_This program requires .NET Core SDK to run. [Here is a free tutorial](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-c-and-net) for installing .NET on Mac or Windows 10 from the [official website](https://dotnet.microsoft.com/download/dotnet-core/)._ 

### Requirements to Run
* _.NET Core_
* _ASP.NET Core MVC_
* _Command Prompt_
* _Web Browser_ 

### Instructions

*This page may be viewed by:*

1. Download and install .NET Core from the [official website](https://dotnet.microsoft.com/download/dotnet-core/)
2. Clone the [repository](https://github.com/TSiu88/rock-paper-scissors.git) from my [GitHub page](https://github.com/TSiu88)
3. Use a command line interface to move to the repository's directory with `cd project-directory`
4. Run `dotnet restore` and `dotnet build` in command line interface of the repository's directory
5. Run `dotnet run` to start up the program in the command line interface
6. Type the URL listed under "Now listening on:" into a web browser


## Other Technologies Used

* _C#_
* _HTML_
* _CSS_
* _MSTest_
* _Razor_
* _Markdown_

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

## Known Bugs

_There are currently no known bugs in this program_

## Support and contact details

_If there are any question or concerns please contact me at my [email](mailto:tsiu88@gmail.com). Thank you._

### License

*This software is licensed under the MIT license*

Copyright (c) 2020 **_Tiffany Siu, Andriy Veremyeyev_**
