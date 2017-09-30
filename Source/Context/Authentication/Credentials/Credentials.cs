// Credentials.cs
// Copyright (c) 2016-2018 BuyBuddy Elektronik Güvenlik Bilişim Reklam Telekomünikasyon Sanayi ve Ticaret Limited Şirketi ( https://www.buybuddy.co/ )
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

namespace BuyBuddy.Context.Authentication {
    /// <summary>
    /// A class that contains user credentials for challenging the platforms
    /// authentication authority with email (aka BuyBuddy ID) and password.
    /// <seealso cref="BuyBuddy.Context.Authentication.CredentialsPersistence" />
    /// </summary>
    /// <remarks>
    /// This class should not be subclassed.
    /// </remarks>
    public class Credentials {
        private string email;
        private string password;

        /// <summary>
        /// Users identity in our platform.
        /// </summary>
        public string Email {
            get {
                return email;
            }
            private set {
                email = value;
            }
        }

        /// <summary>
        /// Users password.
        /// </summary>
        public string Password {
            get {
                return password;
            }
            private set {
                password = value;
            }
        }

        public Credentials(string email, string password) {
            this.email = email;
            this.password = password;
        }
    }
}
