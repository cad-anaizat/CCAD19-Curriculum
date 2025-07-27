# Exercise: Git Local Repository Initialization and Basic Workflow

**Module:** Git / CLI

---

## Goal

Learn fundamental Git workflows including creating a local repository, tracking files, staging, committing, and viewing commit history using CLI.

---

## Starter Code / CLI

```bash
mkdir demos
cd demos
mkdir demo1
cd demo1
git init

# Create gitignore file
dotnet new gitignore

# Create a new file 'file1.txt' with initial content
echo "file one" > file1.txt

## Implementation Tasks
Initialize a Git repository in a local folder

Create a .gitignore file with typical .NET excludes

Create a text file named file1.txt

Use git status to check file states

Stage the file using git add

Commit using git commit with a message

Use git log to view commit history

## Expected Output
git status shows untracked files at first

After git add, files move to the staging area

After git commit, they are saved in the repo

git log displays commit ID, author, timestamp

## Final CLI Commands
git status
git add file1.txt
git commit -m "Initial commit: Add file1.txt"
git log


## Key Concepts Covered
git init creates a new repo

.gitignore prevents junk files from being tracked

File lifecycle: Untracked → Staged → Committed

git add stages changes

git commit saves snapshots

git log reveals commit history and authorship

## Suggested Git Commit Message
Add initial Git exercise: init repo, add and commit file


##Exercise completed as part of MSSA Technical Foundations module

