# Compiler Design – Simple Lexical Analyzer (Scanner)

## 👥 Team Members
- Mahmoud Ahmed  
- Mazen Waleed
- Hazem Essam  
- ElHassan Ibrahim
- Ahmed Gomaa 

## 📘 Project Description
This project is part of the **Compiler Design** course.  
The aim of this task is to build a **Simple Lexical Analyzer (Scanner)** using **C#**.  
The program reads a piece of C code and analyzes it to classify each token such as keywords, identifiers, numbers, operators, special characters, characters, and comments.

## ⚙️ How It Works
When you run the program, it waits for a line of C code from the user.  
After pressing **Enter**, the program scans and prints each token in order.

Each token is displayed in this format:
```
<TOKEN_TYPE, VALUE>
```

### Example
**Input:**
```c
int x = 5; // variable declaration
```

**Output:**
```
<KEYWORD, int>
<IDENTIFIER, x>
<OPERATOR, =>
<NUMBER, 5>
<SPECIAL CHARACTER, ;>
<COMMENT, // variable declaration>
```

## 🔍 Token Types
The analyzer detects and classifies the following types:

- **KEYWORD** → Reserved words like `int`, `if`, `else`, `main`
- **IDENTIFIER** → Variable or function names like `x`, `sum`
- **NUMBER** → Numeric values like `10`, `3.14`
- **OPERATOR** → Operators such as `+`, `-`, `*`, `/`, `=`, `>`, `<`, `==`, `!=`
- **SPECIAL CHARACTER** → Symbols like `()`, `{}`, `[ ]`, `;`, `,`
- **CHARACTER** → String or character literals like `"Hello"` or `'A'`
- **COMMENT** → Both single-line (`// ...`) and multi-line (`/* ... */`) comments

## 💻 Technologies Used
- **Language:** C#  
- **Concepts:** Regular Expressions, Lexical Analysis, Token Classification

## 🧠 Purpose of the Project
This project represents the **Lexical Analysis phase** of a compiler.  
It scans source code, identifies the basic language components, and produces tokens.  
These tokens are the foundation for later stages like the **Parser** and **Semantic Analyzer**.

## 🏁 How to Run
1. Open the project in **Visual Studio** or any C# IDE.  
2. Run the program.  
3. Type or paste a line of C code.  
4. Press **Enter** and view the output tokens immediately.

## 📄 Notes
This simple lexical analyzer is the first step toward building a full compiler.  
In future versions, we can extend it with a **Parser** to validate syntax and build an **Abstract Syntax Tree (AST)**.
