# Numeric Sequence Project

This shows a numeric Sequences based on input given by the user.

<b>How to use</b>

1. Download the Zip file
2. Unzip it to a new or empty folder
3. Open the  "NumericSequenceWithTest.sln" solution (original source was created using Visual Studio 2013 Ultimate)
4. The Solution has 3 projects. "NumericSequence", "NumericSequence.Tests" and "CodedUITestNumericSequence". Make sure that "NumericSequence" web project is selected as StartUp project.
5. Rebuild the Solution
6. Run the application (F5 or Ctrl +F5 to run without debuging)
7. Enter a whole number in to the text box (next to label "Enter an integer")  and press enter or hit the Show button. It must be 1 or greater than 1 in the text box.

<b>Unit Tests</b>

1. Select Unit Test project  "NumericSequence.Tests".
2. Open "HomeControllerTest.cs". There are test methods for each function
3. Right click on a function name and select "Run Test" (Ctrl + R+T). Function "GetCustomisedNumbers" writes output in to the console. Click on the "Output" link in the Test Explorer window.

<b>UI Test </b>

1. Select "CodedUITestNumericSequence" project
2. "CodedUITestMethod1" method in "ManualCodedUITest.cs" is written manually. Run the test by right clicking  and selecting "Run Test"
3. First run the web site using Ctrl + F5. Leave the browser window open.
4. "ReCordedUITestMethod" method in the 'RecordedCodedUITest.cs" is recorded UI test. Run the test by right clicking  and selecting "Run Test" on "ReCordedUITestMethod".
