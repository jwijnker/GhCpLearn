# Agent Instructions

## General

When adding or updating code (fixes) make sure the code quality, readability and maintainability of the source file is optimal.

For example: when a new if-statement is added or updated, make sure the there are no 2 (almost) equally statements follow up on each other.

## API Endpoints

All API endpoints must be defined in the `GhTrainingLib.Api/Endpoints` folder.

When adding a new endpoint, place its implementation in that folder, register it through the existing central `MapEndpoints()` mapping method, and define a corresponding request in a `.http` file for testing.