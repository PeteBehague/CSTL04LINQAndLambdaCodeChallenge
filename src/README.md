# LINQ and Lambda Coding Challenge
In this challenge, there is no step-by-step guide and no hints. However, if you get really stuck, the full solution is located in the ModelSolutionIfYouNeedIt.Code project.

The challenge gives you a starter project that creates a collection of strings that get read in from a file. The strings are the names given to Scotland’s fleet of gritting lorries that are kept busy over the winter, keeping the country’s roads free from ice and snow - see ```Trunk Road Gritter Tracker (arcgis.com)```. Note: Depending on the time of year when you tackle this challenge, the link may be a little underwhelming. You are expected to use the collection of names in the following challenges.

# Task
Locate the LINQAndLambdaChallenge.Code console application. Open the ```Program.cs``` files, locate the Main method and add code beneath the "Your Challenge Code goes here:" comment that addresses the following requirments:

1.  Use 'query' notation to create a LINQ query that returns a list of lorry names called 'gritters' whose names start with the letter ‘G’ (making the search case insensitive).

2.  Use the ForEach method of the gritters collection to write all the names in the collection to the console with each lorry name appearing on a new line.

3.  Use 'method (lambda)' notation to create a Lambda expression that generates the same result set, as created in Steps 1 and 2.

4.  Create a LINQ query, using 'query' notation, that returns a list of lorry names called 'snowGritters' whose names are made up of only two words one of which contains the word 'snow' (making the search case insensitive). You may want to tackle this one element at a time, i.e., find names that are made up of two words, before worrying about finding the word snow. As a hint, you may want to investigate the string data type’s Split method and the List data type’s Count method.

5.  Use the ForEach method of the gritter collection to write all the names in the collection to the console with each lorry name appearing on a new line.

6.  Create a query using 'method (lambda)' notation that generates the same result set as created in Steps 4 and 5.


# To Run the Project
-  Select "Start Debugging" or "Run Without Debugging" from Visual Studio Code's "Run" menu or press F5 or Ctrl+F5
-  To interact with the console (and view the program's output) select the "Terminal" option from Visual Studio Code's View Menu (or press Ctrl+')  

# Execute Unit Tests
At any time you can invoke the unit tests that will be used to determine whether you have successfully completed the challenge by selecting the "Terminal" option from Visual Studio Code's View Menu (or pressing Ctrl+')) and running the following command:

```
dotnet test
```
If all the tests pass you will see a message (in green) that states <span style="color:green">"Passed!  - Failed:   0..."</span>. If any of the tests fail tou will see a message in red that states <span style="color:red">"Failed! - Failed:    n..."</span> where n indicates the number of tests that have failed.

__Note:__ You are NOT (yet) expected to understand how to create your own unit tests nor to interpret the results beyond knowing whether the tests have passed or failed. You will be looking at unit testing as the final topic of this digital course.

# Model Solution (__but only if you need it__)
The code for a model solution can be found in the ```ModelSolutionIfYouNeedIt.Code``` project 