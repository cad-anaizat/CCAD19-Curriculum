#  Exercise: Docker Container Creation and Management (Windows)

**Module:** Docker / CLI

---

## Goal

Understand Docker containers on Windows Server by pulling an image, running and interacting with containers, verifying isolation, and managing the container lifecycle.

---

## Starter CLI Commands

```bash
# Pull Nano Server image
docker pull mcr.microsoft.com/windows/nanoserver:ltsc2022

# Run an interactive CMD container
docker run -it mcr.microsoft.com/windows/nanoserver:ltsc2022 cmd.exe

# Run a ping command inside a temporary container
docker run --rm mcr.microsoft.com/windows/nanoserver:ltsc2022 ping -t localhost

# List running containers
docker ps

# Stop container
docker container stop [container_id]

# Remove container
docker container rm [container_id]

# Remove image
docker rmi [image_id]
