using BlazorPong3.Shared;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPong3.Server
{
    public class GameHub : Hub
    {
        /// <summary>
        /// connectionId-to-username lookup
        /// </summary>
        /// <remarks>
        /// Needs to be static as the chat is created dynamically a lot
        /// </remarks>
        private static readonly Dictionary<string, string> userLookup = new Dictionary<string, string>();

        /// <summary>
        /// Send a message to all clients
        /// </summary>
        /// <param name="username"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public async Task SendMessage(string username, string message)
        {
            await Clients.All.SendAsync(SignalRMessages.RECEIVE, username, message);
        }

        public async Task BallPositionMessage(string username, string message)
        {
            await Clients.All.SendAsync(SignalRMessages.BALL_POSITION, username, message);
        }

        /// <summary>
        /// Register username
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public async Task Register(string username)
        {
            var currentId = Context.ConnectionId;
            if (!userLookup.ContainsKey(currentId))
            {
                // maintain a lookup of connectionId-to-username
                userLookup.Add(currentId, username);
                // re-use existing message for now
                await Clients.AllExcept(currentId).SendAsync(
                    SignalRMessages.RECEIVE,
                    username, $"{username} joined the game");

                //Console.WriteLine($"userLookup:{userLookup.Count}");

                if (userLookup.Count == 1)
                {
                    Console.WriteLine($"userLookup:{1}");

                    await Clients.Client(currentId).SendAsync(
                    SignalRMessages.PLAYER_ID,
                    username, "1");
                }
                else
                {
                    Console.WriteLine($"userLookup:{2}");
                    await Clients.Client(currentId).SendAsync(
                    SignalRMessages.PLAYER_ID,
                    username, "2");
                }
            }
        }

        /// <summary>
        /// Log connection
        /// </summary>
        /// <returns></returns>
        public override Task OnConnectedAsync()
        {
            Console.WriteLine("Connected");
            return base.OnConnectedAsync();
        }

        /// <summary>
        /// Log disconnection
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public override async Task OnDisconnectedAsync(Exception e)
        {
            Console.WriteLine($"Disconnected {e?.Message} {Context.ConnectionId}");
            // try to get connection
            string id = Context.ConnectionId;
            if (!userLookup.TryGetValue(id, out string username))
                username = "[unknown]";

            userLookup.Remove(id);
            await Clients.AllExcept(Context.ConnectionId).SendAsync(
                SignalRMessages.RECEIVE,
                username, $"{username} has left the game");
            await base.OnDisconnectedAsync(e);
        }
    }
}
