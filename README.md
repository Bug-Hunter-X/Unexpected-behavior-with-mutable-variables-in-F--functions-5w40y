# F# Mutable Variable Bug

This repository demonstrates an unexpected behavior related to mutable variables in F#. When a mutable variable is passed to a function, changes made to it within the function do *not* reflect in the original variable's value outside the function. This example showcases the issue and proposes a solution.

## Bug Description

The bug involves a mutable integer variable (`x`) and a function (`addOne`) that increments its value. Although the function successfully modifies `x`, the original `x`'s value remains unchanged outside of the `addOne` scope.

## Solution

The solution demonstrates how to properly manage changes to mutable variables using techniques like returning a new value or using references.