# Simple Compiler & Syntax Checker (Form4)

This project is a **C# Windows Forms application** that performs **syntax analysis and interpretation** of a simplified programming language. `Form4.cs` represents the final and most feature-complete version of the compiler.

## 🚀 Features

* **Syntax Validation**

  * Checks for undeclared variables
  * Ensures all opened `(`, `{` are closed properly
  * Validates statement endings (`;`, `:`, etc.)
  * Detects missing expressions or incorrect line endings

* **Variable Declaration & Tracking**

  * Tracks declared variables with their type and assigned value
  * Prevents redefinition and use of reserved keywords as identifiers

* **Array Support**

  * Parses array declarations and values
  * Allows indexing and modification of array elements

* **Control Structures Check**

  * Validates structure of `if`, `else`, `for`, `while`, `switch`, and `case`
  * Ensures each `case` block ends with a `break`
  * Checks for matching opening and closing brackets

* **Expression Evaluation**

  * Supports arithmetic operations with literals and variables
  * Handles compound assignments (`+=`, `-=`, `*=`, `/=`)
  * Updates variable values dynamically during interpretation

* **Visual Output**

  * Errors are displayed in an error listbox
  * Symbol table including variables and arrays is shown in a memory listbox

## 🧠 How It Works

* As the user types code in a TextBox, the application tokenizes and parses the input.
* It uses custom logic (no external parser libraries) to simulate a basic compiler:

  * **Lexical Analysis**: Tokenizes input based on space and special characters
  * **Syntax Analysis**: Matches known rules for declarations, loops, conditions
  * **Semantic Analysis**: Detects semantic errors like undeclared variables
  * **Interpretation**: Updates values of variables and arrays after expressions

## 🖼️ Example Input

```c
int x = 5;
int y = x + 2;
if (x < y) {
  y += 1;
}
switch(x) {
  case 5:
    y += 10;
    break;
  default:
    y -= 2;
    break;
}
```

## 🛠️ Technologies Used

* C# (.NET Framework)
* Windows Forms

## 🧩 File Structure

* `Form4.cs` – Main compiler logic and UI for code checking
* `Form1.cs` – Main menu UI to navigate to Final Phase
* `Form2.cs`, `Form3.cs` – Earlier phases of the project

## 🧪 How to Run

1. Open the solution in **Visual Studio**.
2. Set **Form1** as the startup form.
3. Run the application and choose **Final Phase** from the menu.
4. Type or paste your code into the text box.
5. Errors and variables will be shown as you type.

## 📌 Notes

* This tool is meant for educational purposes and demonstrating compiler design fundamentals.
* It does not use formal parsing algorithms (like recursive descent or CFG parsing), but instead uses manual rule checking.

