// Passphrase.cs
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

using System;
using System.Threading;

namespace BuyBuddy.Context.Authentication {
    using BuyBuddy.Entities;
    using BuyBuddy.Context.Authentication.Persistence;
    using System.Threading.Tasks;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Passphrase represents an access key to perform an authentication of
    /// the user. To enhance security, sensitive information such as login
    /// credentials (email, password etc.), passphrases are used as a
    /// middleware.
    /// </summary>
    public sealed class Passphrase : IEquatable<Passphrase> {
        public static readonly Regex PasswordRegex = new Regex("^[0-9a-zA-Z]{88}$");

        /// <summary>
        /// Length of the passkey.
        /// </summary>
        public static readonly int PasskeyLength = 88;

        /// <summary>
        /// Database identifier of the passphrase object.
        /// </summary>
        public readonly int id;

        /// <summary>
        /// Underlying data of the passphrase.
        /// </summary>
        public readonly string passkey;

        /// <summary>
        /// Date of issue of passphrase.
        /// </summary>
        public readonly DateTime issueDate;

        /// <summary>
        /// Owner of the passphrase.
        /// </summary>
        public readonly User owner;

        /// <summary>
        /// Repository of the passphrase.
        /// </summary>
        public IPassphraseRepository repository;

        internal Passphrase(int id, string passkey, DateTime issueDate, User owner) {
            this.id = id;

            if (PasswordRegex.Match(passkey).Success) {
                this.passkey = passkey;
            } else {
                throw new ArgumentException("Parameter should be alphanumeric and exactly 88 characters long.", "passkey");
            }
            
            this.issueDate = issueDate;
            this.owner = owner;
            this.repository = null;
        }

        public bool Equals(Passphrase passphrase) {
            return passphrase != null && id == passphrase.id;
        }

        /// <summary>
        /// Invalidates the passphrase on the remote API.
        /// <para>You should invalidate the passphrase upon sign out request of user.</para>
        /// </summary>
        public async Task InvalidateAsync() {
            return;
        }

        /// <summary>
        /// Persists passphrase with given passphrase repository.
        /// </summary>
        public async Task Persist() {
            await repository.SaveAsync(this);
        }
    }
}
