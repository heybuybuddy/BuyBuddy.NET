// User.cs
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

using BuyBuddy.Context;
using BuyBuddy.Entities.Assets;
using BuyBuddy.Entities.UserManagement.AccessControl;
using System;
using System.Collections.Generic;

namespace BuyBuddy.Entities {
    /// <summary>
    /// The model class representing users of the platform.
    /// 
    /// Every single user registered to the platform could be identified
    /// with objects of this class.
    /// There is no distinction between different types of platform users
    /// (i.e. customers, managers, administrators), all belong to the 
    /// same class.
    /// </summary>
    /// <para>
    /// Objects of this class are provided by this software
    /// development kit are proxies of the objects found in platform,
    /// you might need to fetch the same user repeatedly in various
    /// contexts.
    /// You may compare two instances using
    /// <see cref="System.IEquatable{T}" /> interface, which will perform
    /// equality comparison between identifiers of two users.
    /// Our platform does only guarantee constantness of the identifiers
    /// of the users, do not store another information about users to
    /// identify them.
    /// </para>
    public sealed class User : IEquatable<User> {
        /// <summary>
        /// Database identifier of the user.
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// Current email of the user, also known as BuyBuddy ID.
        /// </summary>
        public string Email { get; private set; }

        /// <summary>
        /// The authentication context user is bound to.
        /// Will be null if user is not authenticated in this device.
        /// </summary>
        public AuthenticationContext BoundContext { get; private set; }

        /// <summary>
        /// Date of the registration.
        /// </summary>
        public DateTime RegistrationDate { get; private set; }

        /// <summary>
        /// A reference to the registrar user.
        /// </summary>
        public User Registrar { get; private set; }

        /// <summary>
        /// First name of the user.
        /// </summary>
        public string FirstName { get; private set; }

        /// <summary>
        /// Family name of the user.
        /// </summary>
        public string FamilyName { get; private set; }
        
        /// <summary>
        /// Full name of the user. Not localized.
        /// </summary>
        public string FullName => $"{FirstName} {FamilyName}";

        /// <summary>
        /// Birth date of the user.
        /// </summary>
        public DateTime DateOfBirth { get; private set; }

        /// <summary>
        /// Affiliate user is currently registered to.
        /// </summary>
        public Affiliate Affiliate { get; private set; }

        /// <summary>
        /// Brand user is currently registered to.
        /// </summary>
        public Brand Brand { get; private set; }

        /// <summary>
        /// Store user is currently registered to.
        /// </summary>
        public Store Store { get; private set; }

        /// <summary>
        /// Department user is currently registered to.
        /// </summary>
        public Department Department { get; private set; }

        /// <summary>
        /// Affiliates registered by the user.
        /// </summary>
        public List<Affiliate> RegisteredAffiliates { get; private set; }

        /// <summary>
        /// Brands registered by the user.
        /// </summary>
        public List<Brand> RegisteredBrands { get; private set; }

        /// <summary>
        /// Stores registered by the user.
        /// </summary>
        public List<Store> RegisteredStores { get; private set; }

        /// <summary>
        /// Departments registered by the user.
        /// </summary>
        public List<Department> RegisteredDepartments { get; private set; }

        /// <summary>
        /// The permission set user is currently bound to.
        /// </summary>
        public PermissionSet CurrentPermissionSet { get; private set; }

        /// <summary>
        /// Permission set grants to other platform users made by user.
        /// </summary>
        public List<PermissionSetGrant> PermissionSetGrants { get; private set; }

        /// <summary>
        /// Permissions of the user.
        /// </summary>
        public List<Permission> Permissions => CurrentPermissionSet.Permissions;

        /// <summary>
        /// The delegate observing the user.
        /// </summary>
        public Delegate Delegate { get; private set; }

        /// <summary>
        /// The delegate registrations made by the user.
        /// </summary>
        public List<Delegate> RegisteredDelegates { get; private set; }

        /// <summary>
        /// Specifies if user uses two-factor authentication scheme.
        /// </summary>
        public bool? UsesTwoFactorAuthentication { get; private set; }

        /// <summary>
        /// Specifies if user prefers to login every time.
        /// </summary>
        /// <para>
        /// Do not persist the passphrase of the user if this property
        /// has a truthy value.
        /// </para>
        public bool? RequiresLoginEverytime { get; private set; }

        internal User(int id, AuthenticationContext context) {
            Id = id;
            BoundContext = context;
        }

        /// <summary>
        /// Compares two user objects by making identifier comparison.
        /// </summary>
        /// <param name="user">The second user object to compare.</param>
        /// <returns>Truthy if user objects belong to same user.</returns>
        public bool Equals(User user) {
            return user != null &&
                   Id == user.Id;
        }
    }
}
