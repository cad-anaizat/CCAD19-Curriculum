# Essential Git Commands
Below is a comprehensive list of Git commands introduced and expanded upon, with descriptions and example usages.

| Command                       | Description                                      | Example Usage                          |
|-------------------------------|--------------------------------------------------|----------------------------------------|
| `git init`                    | Initializes a new Git repository.                | `git init` (creates .git folder)       |
| `git add <file(s)>`           | Adds specified file(s) to the staging area.      | `git add example.txt`                  |
| `git add .`                   | Stages all modified and new files.               | `git add .`                            |
| `git diff`                    | Shows changes between working directory and index. | `git diff`                             |
| `git diff --staged`           | Compares staged changes with the last commit.    | `git diff --staged`                    |
| `git diff HEAD`               | Compares working directory with the last commit. | `git diff HEAD`                        |
| `git diff --color-words`      | Highlights word-level differences with color.    | `git diff --color-words`               |
| `git commit -m "message"`     | Commits staged files with a message.             | `git commit -m "Add initial content"`  |
| `git branch`                  | Lists all local branches.                        | `git branch`                           |
| `git branch -b <branch>`      | Creates and switches to a new branch.            | `git branch -b feature-branch`         |
| `git branch --all` or `git branch -a` | Lists all local and remote-tracking branches. | `git branch -a`                        |
| `git checkout <branch>`       | Switches to the specified branch.                | `git checkout feature-branch`          |
| `git fetch`                   | Fetches updates from all remote branches.        | `git fetch`                            |
| `git status`                  | Shows status of working directory and staging.   | `git status`                           |
| `git log`                     | Displays the commit history.                     | `git log`                              |
| `git log --oneline`           | Shows condensed commit history.                  | `git log --oneline`                    |
| `git reset --soft HEAD~1`     | Undoes last commit, keeps changes staged.        | `git reset --soft HEAD~1`              |
| `git reset --mixed HEAD~1`    | Undoes last commit, unstages changes (default).  | `git reset --mixed HEAD~1`             |
| `git reset --hard HEAD~1`     | Undoes last commit, discards all changes.        | `git reset --hard HEAD~1`              |
| `git reflog`                  | Shows history of HEAD movements and commits.     | `git reflog`                           |
| `git clone <url>`             | Clones a remote repository to local machine.     | `git clone https://github.com/repo.git` |
| `git pull`                    | Fetches and merges changes from remote.          | `git pull origin main`                 |
| `git push origin <branch>`    | Pushes commits to the specified remote branch.   | `git push origin main`                 |
| `git version`                 | Displays the installed Git version.              | `git version`                          |
| `git config --list`           | Lists all configuration settings.                | `git config --list`                    |
| `git config --global --list`  | Lists global configuration settings.             | `git config --global --list`           |
| `git config --system --list`  | Lists system-wide configuration settings.        | `git config --system --list`           |
| `git config --local`          | Lists repository-specific configuration.         | `git config --local`                   |
| `git config --global user.name "First Name"` | Sets global username.         | `git config --global user.name ""` |
| `git config --global user.email "you@email.com"` | Sets global email.       | `git config --global user.email ".hereim@"` |
| `git config --global core.autocrlf true` | Sets Windows line endings.  | `git config --global core.autocrlf true` (Windows) |
| `git config --global core.autocrlf input` | Sets Mac/Linux line endings. | `git config --global core.autocrlf input` (Mac/Linux) |
| `git config --global core.editor "code --wait"` | Sets VS Code as editor. | `git config --global core.editor "code --wait"` |
| `git help <verb>`             | Displays help for a specific command.            | `git help commit`                      |
| `man git-<verb>`              | Opens manual page for a command.                 | `man git-commit`                       |
| `git help config`             | Shows help for git config.                       | `git help config`                      |
| `git log`                     | Displays commit history (detailed).              | `git log`                              |
| `git log --oneline`           | Condensed commit history.                        | `git log --oneline`                    |
| `git log --oneline --graph`   | Shows commit history with branch graph.          | `git log --oneline --graph`            |
| `git log --oneline --graph --decorate` | Adds branch/tag info.   | `git log --oneline --graph --decorate` |
| `git log --oneline --graph --decorate --all` | Includes all refs. | `git log --oneline --graph --decorate --all` |
| `git log --stat`              | Shows commit stats (files changed).              | `git log --stat`                       |
| `git log --patch`             | Displays commit diffs in patch format.           | `git log --patch`                      |
| `git ignore`                  | Note: Likely a typo; intended as `.gitignore` to specify excluded content. | Create `.gitignore` with `dotnet new gitignore` |

*Note: `git ignore` is corrected to `.gitignore` usage, as it’s a file, not a command. Use `dotnet new gitignore` or manual creation to define exclusions.*

