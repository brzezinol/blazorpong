namespace BlazorPong3.Shared
{
    public class SignalRMessages
    {
        /// <summary>
        /// Event name when a message is received
        /// </summary>
        public const string RECEIVE = "ReceiveMessage";

        /// <summary>
        /// Name of the Hub method to register a new user
        /// </summary>
        public const string REGISTER = "RegisterMessage";

        /// <summary>
        /// Name of the Hub method to send a message
        /// </summary>
        public const string SEND = "SendMessage";

        /// <summary>
        /// Name of the Hub method to send a message
        /// </summary>
        public const string BALL_POSITION = "bpm";

        public const string PLAYER_ID = "PlayerIDMessage";

        public const string START_GAME = "StartGameMessage";

        public const string DISCONNECT = "DisconnectedMessage";

        public const string PALETTE_POSITION = "ppm";
    }
}
