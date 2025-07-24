# Common Git Processes
The following fully coded examples demonstrate practical Git workflows, executable in a terminal or simulated in C# for learning.
## Process 1: Initialize a Repository and First Commit
- **Description**: Sets up a new Git repository and commits an initial file.
- **Terminal Commands**:
```bash
mkdir MyProject
cd MyProject
git init
echo "Initial content" > README.md
git add README.md
git commit -m "Initial commit with README"
```
## Process 2: Stage and Commit Changes
- **Description**: Adds changes to the staging area and commits them to history.
- **Terminal Commands**:
```bash
git add .
git commit -m "Describe the changes made"
```
## Process 3: Check Status, Diffs, and History
- **Description**: Check what files are changed, staged, and committed.
- **Terminal Commands**:
```bash
git status
git diff
git diff --staged
git log
git log --oneline
git log --oneline --graph
git log --oneline --graph --decorate --all
```
## Process 4: View Word-Level Changes with Color
- **Description**: Show inline differences at the word level with highlights.
- **Terminal Commands**:
```bash
git diff --color-words
```
## Process 5: Create and Use a Feature Branch
- **Description**: Create and switch to a new branch for isolated feature development.
- **Terminal Commands**:
```bash
git checkout -b feature/login-system
# Make your feature changes...
git add .
git commit -m "Add login form and validation"
git push origin feature/login-system
```
## Process 6: Switch Between Branches
- **Description**: Move between existing branches.
- **Terminal Commands**:
```bash
git branch
git branch -a
git checkout main
git checkout feature/login-system
```
## Process 7: Create and Commit a New File
- **Description**: Create a file and add it to version control.
- **Terminal Commands**:
```bash
echo "Example content" > example.txt
git add example.txt
git commit -m "Add example.txt"
```
## Process 8: Fetch, Pull, and Push Changes
- **Description**: Sync local repository with remote changes and share your updates.
- **Terminal Commands**:
```bash
git fetch
git pull origin main
git push origin main
```
## Process 9: Undo Recent Commits or Changes
- **Description**: Roll back commits with soft, mixed, or hard resets.
- **Terminal Commands**:
```bash
git reset --soft HEAD~1
git reset --mixed HEAD~1
git reset --hard HEAD~1
git reflog
```
## Process 10: Configure Git Settings
- **Description**: Set your identity, editor, and line ending preferences.
- **Terminal Commands**:
```bash
git config --global user.name ""
git config --global user.email ".@"
git config --global core.autocrlf true
git config --global core.editor "code --wait"
git config --list
```
## Process 11: Delete a Tracked Directory or File
- **Description**: Remove a file or folder from Git and commit the deletion.
- **Terminal Commands**:
```bash
rm -rf obsolete-folder
git rm -r obsolete-folder
git commit -m "Remove obsolete-folder"
```
## Process 12: Get Help and View Command Documentation
- **Description**: Use Git’s built-in help to learn more about commands.
- **Terminal Commands**:
```bash
git help
git help commit
man git-commit
git help config
```
## Process 13: Clone a Remote Repository
- **Description**: Download a full copy of a remote repository.
- **Terminal Commands**:
```bash
git clone https://github.com/yourusername/project.git
cd project
```
## Process 14: Set Up .gitignore
- **Description**: Prevent temporary or sensitive files from being tracked.
- **Terminal Commands**:
```bash
dotnet new gitignore
# or manually:
echo "bin/" >> .gitignore
echo "obj/" >> .gitignore
git add .gitignore
git commit -m "Add .gitignore file"
```
## Process 15: View Commit Stats and Patch Diffs
- **Description**: Review what files were changed and how.
- **Terminal Commands**:
```bash
git log --stat
git log --patch
```
## Process 16: Check Installed Git Version
- **Description**: Display your currently installed Git version.
- **Terminal Commands**:
```bash
git --version
```
