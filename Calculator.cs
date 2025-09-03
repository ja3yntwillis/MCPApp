using ModelContextProtocol.Server;
using System;
using System.ComponentModel;
using System.Linq;
namespace MCPApp
{
    [McpServerToolType] // this tells MCP to scan for tools here
    public static class Calculator
    {
        [McpServerTool, Description("Echoes the message back to the client.")]
        public static string Echo(string message) => $"Hello from C#: {message}";

        [McpServerTool, Description("Echoes in reverse the message sent by the client.")]
        public static string ReverseEcho(string message) => new string(message.Reverse().ToArray());
    }

}

