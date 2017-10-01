// PassphraseRepository.cs
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

namespace BuyBuddy.Context.Authentication.Persistence {
    using BuyBuddy.Context.Authentication;
    using System.Threading.Tasks;

    /// <summary>
    /// The interface
    /// <see cref="IPassphraseRepository">IPassphraseRepository</see>
    /// is implemented by an object who mediates the coordination of
    /// persistence in a storage back-end.
    /// Later, the object should be able to reoccupy that previously persisted
    /// object.
    /// <para>
    /// As a mediator of the persistence back-end, the implementations should
    /// not leak any information about the underlying storage layer, and it
    /// should recover from the errors if error arises from storage layer.
    /// </para>
    /// <para>
    /// Persisting a user passphrase is directly related with our privacy
    /// policy.
    /// An insecure implementation may lead to leaked sensitive information of
    /// users.
    /// We do not force you to store the user credentials somewhere
    /// (like Windows Vault / Credentials Manager), nevertheless one should
    /// think twice before implementing this interface in a homebrew class.
    /// We highly encourage you to check out
    /// </para>
    /// </summary>
    public interface IPassphraseRepository {
        Task SaveAsync(Passphrase passphrase);
        Task<Passphrase> LoadAsync();
    }
}
