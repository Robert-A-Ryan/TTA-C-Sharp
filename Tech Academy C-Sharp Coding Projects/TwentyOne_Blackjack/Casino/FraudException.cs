using System;

namespace Casino.TwentyOne_Blackjack
{
    public class FraudException : Exception
    {
        public FraudException()
            : base() { }
        public FraudException(string message)
            : base(message) { }
    }
}
