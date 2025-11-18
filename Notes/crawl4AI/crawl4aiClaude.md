# Crawl4AI MCP Setup Guide for LM Studio

## Prerequisites
- Docker Desktop installed and running
- LM Studio installed

## Step 1: Pull the Latest Crawl4AI Docker Image

**IMPORTANT:** Always pull the `:latest` tag to avoid known bugs in older versions.
```ps
docker pull unclecode/crawl4ai:latest
```

**Problem:** If the pull is slow or fails
- Check your internet connection
- Try restarting Docker Desktop

---

## Step 2: Run the Crawl4AI Container
```ps
docker run -d `
  --name crawl4ai-mcp `
  -p 11235:11235 `
  -p 11234:11234 `
  unclecode/crawl4ai:latest
```

**Problem:** Port already in use error
- **Solution:** Stop any existing containers using these ports:
```ps
docker ps
docker rm -f crawl4ai-mcp
```
Then run the docker run command again.

**Problem:** Forgot to add `:latest` tag
- **Solution:** You may be running an older version with bugs. Update with:
```ps
docker pull unclecode/crawl4ai:latest; docker rm -f crawl4ai-mcp; docker run -d --name crawl4ai-mcp -p 11235:11235 -p 11234:11234 unclecode/crawl4ai:latest
```

---

## Step 3: Verify the Container is Running

Check container status:
```ps
docker ps
```

You should see `crawl4ai-mcp` with status "Up" and "(healthy)".

Test the HTTP API endpoint:
```ps
Invoke-RestMethod http://localhost:11235/
```

**Problem:** Connection refused or "Not Found" errors
- Wait 30-60 seconds for the container to fully start
- Check logs: `docker logs crawl4ai-mcp`
- Verify the container is healthy: `docker ps`

---

## Step 4: Install Node.js

Node.js is required for the MCP connection to work with LM Studio.
```ps
winget install OpenJS.NodeJS.LTS
```

**Important:** After installation, close and reopen PowerShell (and LM Studio if it's running).

Verify installation:
```ps
node --version
npx --version
```

**Problem:** Command not found after installation
- **Solution:** Restart PowerShell/terminal
- If still not working, log out and back in to Windows

---

## Step 5: Configure LM Studio MCP Server

1. Open LM Studio
2. Go to **Settings** → **Developer** → **MCP Servers** (or open your MCP config JSON file)
3. Add the Crawl4AI server configuration:
```json
{
  "mcpServers": {
    "crawl4ai": {
      "transport": "sse",
      "url": "http://localhost:11235/mcp/sse"
    }
  }
}
```

**Note:** The correct endpoint is `/mcp/sse`, NOT just `/sse`.

4. Save the configuration
5. Restart LM Studio

**Problem:** "404 Not Found" or "Connection closed" errors
- **Common mistake:** Using `http://localhost:11235/sse` instead of `http://localhost:11235/mcp/sse`
- **Solution:** Verify the URL includes `/mcp/sse`
- Check container is running: `docker ps`
- Check LM Studio logs for specific error messages

**Problem:** MCP shows connected but tool calls fail constantly
- **Symptom:** Docker logs show `AssertionError: Unexpected message` with ASGI/HTTP errors
- **Root cause:** You're running an older version of the container with a known SSE bug
- **Solution:** Update to the latest version:
```ps
docker pull unclecode/crawl4ai:latest; docker rm -f crawl4ai-mcp; docker run -d --name crawl4ai-mcp -p 11235:11235 -p 11234:11234 unclecode/crawl4ai:latest
```
Wait 30 seconds, then restart LM Studio and reconnect.

---

## Step 6: Verify MCP Connection

In LM Studio, you should now see Crawl4AI tools available in your chat.

Check available tools by visiting in your browser:
```
http://localhost:11235/mcp/schema
```

**Test the connection:**
1. Start a chat in LM Studio
2. Ask it to crawl a simple website (e.g., "Can you crawl https://example.com?")
3. The model should successfully call the Crawl4AI tools

Correct setup should show:
![alt text](image.png)

---

## Troubleshooting Commands

**Check container version:**
```ps
docker exec crawl4ai-mcp python -c "import crawl4ai; print(crawl4ai.__version__)"
```

**View recent container logs (look for errors):**
```ps
docker logs crawl4ai-mcp --tail 50
```

**Stop the container:**
```ps
docker stop crawl4ai-mcp
```

**Remove the container:**
```ps
docker rm -f crawl4ai-mcp
```

**Check if ports are listening:**
```ps
Test-NetConnection -ComputerName localhost -Port 11235
Test-NetConnection -ComputerName localhost -Port 11234
```

**Complete restart (when things go wrong):**
```ps
docker pull unclecode/crawl4ai:latest; docker rm -f crawl4ai-mcp; docker run -d --name crawl4ai-mcp -p 11235:11235 -p 11234:11234 unclecode/crawl4ai:latest
```
Wait 30 seconds, then restart LM Studio.

---

## Common Issues Summary

| Issue | Solution |
|-------|----------|
| Port already in use | `docker rm -f crawl4ai-mcp` then retry |
| Connection refused | Wait 30-60s for container startup |
| 404 Not Found in LM Studio | Check endpoint is `/mcp/sse` not `/sse` |
| Node.js not found | Restart PowerShell after installation |
| Container not healthy | Check `docker logs crawl4ai-mcp` |
| MCP connects but tools fail | Update to `:latest` - older versions have SSE bugs |
| AssertionError in docker logs | Update container to latest version |
| Tools timeout/hang | Check `docker logs` for errors, restart container |

---

## Notes
- **Always use the `:latest` tag** - older versions have known bugs
- Port 11235 is the main HTTP API and MCP SSE endpoint
- Port 11234 is used internally (not directly accessed)
- The MCP server is integrated into the FastAPI app on port 11235
- Keep Docker Desktop running while using Crawl4AI
- If you encounter issues after setup, try updating to latest: `docker pull unclecode/crawl4ai:latest` and recreate the container

---

## Quick Reference: One-Line Commands

**Full setup (after Docker Desktop is running):**
```ps
docker pull unclecode/crawl4ai:latest; docker run -d --name crawl4ai-mcp -p 11235:11235 -p 11234:11234 unclecode/crawl4ai:latest
```

**Full restart/update:**
```ps
docker pull unclecode/crawl4ai:latest; docker rm -f crawl4ai-mcp; docker run -d --name crawl4ai-mcp -p 11235:11235 -p 11234:11234 unclecode/crawl4ai:latest
```

**Quick cleanup:**
```ps
docker rm -f crawl4ai-mcp
```