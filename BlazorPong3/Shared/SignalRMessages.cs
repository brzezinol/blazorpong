namespace BlazorPong3.Shared
{
    public class SignalRMessages
    {
        /// <summary>
        /// Event name when a message is received
        /// </summary>
        public const string RECEIVE = "rm";

        /// <summary>
        /// Name of the Hub method to register a new user
        /// </summary>
        public const string REGISTER = "reg";

        /// <summary>
        /// Name of the Hub method to send a message
        /// </summary>
        public const string SEND = "sm";

        /// <summary>
        /// Name of the Hub method to send a message
        /// </summary>
        public const string BALL_POSITION = "bpm";

        public const string PLAYER_ID = "pim";

        public const string START_GAME = "sgm";
    }
}
