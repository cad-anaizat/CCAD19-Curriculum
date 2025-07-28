# Exercise: Git Basics – Add, Commit, Push, Pull

**Module:** Git / CLI

---

## Goal

Practice fundamental Git commands to track, commit, and sync code with a remote repository.

---

## Starter CLI Commands

```bash
git init
git status
git add <filename>
git commit -m "commit message"
git log
git push origin main
git pull origin main


## Implementation Tasks
Create and modify files locally

Use git status to view current state

Stage changes with git add

Commit those changes with a clear message

Push commits to GitHub

Pull remote changes to stay in sync


## Expected Output
git status shows file states (untracked, modified, staged)

git log shows commit history

git push sends commits to GitHub

git pull fetches and merges remote changes


## Final Command Sample
echo "new content" > update.txt
git add update.txt
git commit -m "Add update.txt with sample content"
git push origin main


## Key Concepts Covered
Working directory, staging area, and repository

Lifecycle of changes: untracked → staged → committed

Difference between git add . vs git add <file>

GitHub as the remote origin for collaboration