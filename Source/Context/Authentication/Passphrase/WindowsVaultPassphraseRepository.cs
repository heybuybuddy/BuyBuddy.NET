

namespace BuyBuddy.Context.Authentication.Persistence {
    using BuyBuddy.Context.Authentication;

    /// <summary>
    /// Stores passphrase in Windows Vault / Credentials Manager.
    /// <para>This class is dependent on availability of
    /// Windows Value / Credentials API on target.
    /// </para>
    /// </summary>
    public class WindowsVaultPassphraseRepository {
        private static readonly string PassphraseTarget = "\\Windows\\BuyBuddy\\Passphrase\\";

        public async void Save() {
            using (var cred = new Credential()) {
                cred.Password = password;
                cred.Target = PassphraseTarget;
                cred.Type = CredentialType.Generic;
                cred.PersistanceType = PersistanceType.LocalComputer;
                cred.Save();
            }
        }

        public async Task<Passphrase> Load() {

        }
    }
}
