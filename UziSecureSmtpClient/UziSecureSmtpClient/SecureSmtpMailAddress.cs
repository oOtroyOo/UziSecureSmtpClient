
namespace UziSecureSmtpClient
{
    public class SecureSmtpMailAddress
    {
        public string Address { get; private set; }
        public string DisplayName { get; private set; }
        public SecureSmtpMailAddress(string address, string name)
        {
            this.Address = address;
            this.DisplayName = name;
            if (string.IsNullOrEmpty(DisplayName))
            {
                DisplayName = address.Split('@')[0];
            }
        }
        public SecureSmtpMailAddress(string address) : this(address, null)
        {
        }

    }

}
