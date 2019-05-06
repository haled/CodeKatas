# String Calculator Kata #

## Overview ##
Below I describe a basic version of the String Calculator Kata.  My master branch of this repository contains the initial implementation I created by following the steps below for the kata.  As I try out different programming techniques, I will describe the technique below and create a branch for it.  (I'm still debating whether the different techniques are best learned by branching the original solution and modifying it or by creating the solution from scratch.  I will try both in the repository at some point.)

## Blatant Oversight ##
I am using C#, .NET Core, and XUnit in this repository for the solutions.  Obviously, the katas can be implemented in other languages and platforms.  An exercise of the katas could be for learning different unit testing frameworks.  For simplicity, I'm going to keep this repository focused on C#, .NET Core, and XUnit.  (At least until I want to try them in a different language. ;))

## String Calculator Kata ##
The following is a TDD Kata- an exercise in coding, refactoring and test-first, that you should apply daily for at least 15 minutes (I do 30).

### Before you start: ###
* Try not to read ahead.
* Do one task at a time. The trick is to learn to work incrementally.
* Make sure you only test for correct inputs. there is no need to test for invalid inputs for this kata

### Kata Requirements ###
1. Create a simple String calculator with a method int Add(string numbers)
2. The method can take 0, 1 or 2 numbers, and will return their sum (for an empty string it will return 0) for example “” or “1” or “1,2”
3. Start with the simplest test case of an empty string and move to 1 and two numbers
4. Remember to solve things as simply as possible so that you force yourself to write tests you did not think about
5. Remember to refactor after each passing test
6. Allow the Add method to handle an unknown amount of numbers
7. Support different delimiters

### Kata Attribution ###
This is based on the String Calculator kata by Roy Osherove:  http://osherove.com/tdd-kata-1/  I've simplified the requirements to see if I can make it easy to hold in one's head.

## Additional Techniques ##

### Programming to Interfaces ###
The basic implementation I created didn't need interfaces, yet most of the programming I've done has used interfaces.  Modify the kata to use an interface.
