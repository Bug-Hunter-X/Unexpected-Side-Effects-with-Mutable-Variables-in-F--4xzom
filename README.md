# F# Mutable Variable Bug

This repository demonstrates a common error in F# involving mutable variables and unexpected side effects within a function. The function `add` modifies its input parameters, leading to unexpected results. The solution provides a way to avoid these issues by using immutable data structures and functional programming concepts.

## Bug Report

The original code uses mutable variables `x` and `y`.  The `add` function modifies these variables, causing the final result to be different than expected.