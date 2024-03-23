What code smells did you see?
- Immobility: You cannot reuse parts of the code in other projects because of involved risks and high effort
- Opacity: The code is hard to understand

What problems do you think the Speaker class has?
- Complexity: The Speaker class is convoluted and challenging to comprehend.
- Monolitic Design: All functionalities are crammed into one class, violating the principle of separation of concerns.
- Fat Method: The 'Register' method is bloated and tighly coupled, leading to maintenance difficulties. 

Which clean code principles (or general programming principles) did it violate?
- Keep it simple, stupid (KISS): The codebase lacks simplicity, making it harder to understand and maintain.

What refactoring techniques did you use?
- Method Extraction: Split the 'Register' method into smaller, more manageable methods to reduce complexity.
- Separation of Concerns: Moved custom exceptions to a separate folder for better organization and clarity.
- Exception Handling: Implemented try-catch blocks around each method with potential exception to encahnce error handling and maintainability.