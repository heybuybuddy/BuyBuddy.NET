using BuyBuddy.Context.Authentication;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BuyBuddy.Context {
    public sealed class AuthenticationContext {
        public enum State {
            AwaitingConcreteAuthentication,
            AwaitingStealthAuthentication,
            Authenticated
        }

        private Credentials Credentials { get; set; }
        private Passphrase Passphrase { get; set; }
        public int StealthAuthenticationCount { get; private set; }
        public State CurrentState { get; private set; }

        public AuthenticationContext(Credentials credentials) {
            Credentials = credentials;
            Passphrase = null;
            StealthAuthenticationCount = 0;
            CurrentState = State.AwaitingConcreteAuthentication;
        }

        public AuthenticationContext(Passphrase passphrase) {
            Credentials = null;
            Passphrase = passphrase;
            StealthAuthenticationCount = 0;
            CurrentState = State.AwaitingStealthAuthentication;
        }

        public bool IsAuthenticated {
            get {
                return CurrentState == State.Authenticated;
            }
        }

        public async Task PerformConcreteAuthenticationAsync() {
            
        }
    }
}
