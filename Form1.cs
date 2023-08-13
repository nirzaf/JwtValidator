using JwtValidationLibrary;
using Newtonsoft.Json;

namespace JwtValidator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonPasteToken_Click(object sender, EventArgs e)
        {
            //paste the token from the clipboard to the text box
            RichTextBoxForToken.Text = Clipboard.GetText();
        }

        private void ButtonValidateToken_Click(object sender, EventArgs e)
        {
            //remove all the spaces from the beginning and the end of the text box text
            RichTextBoxForToken.Text = RichTextBoxForToken.Text.Trim();

            //check if the text box is empty
            if (RichTextBoxForToken.Text == "")
            {
                MessageBox.Show(@"Please paste the token first");
            }
            else
            {
                //check if the token is valid
                var issuerToken = TextBoxIssuerToken.Text.Trim();
                var audience = TextBoxAudience.Text.Trim();
                var issuer = TextBoxIssuer.Text.Trim();

                var tokenValidator = new AccessTokenProvider(issuerToken, audience, issuer);
                var tokenResult = tokenValidator.ValidateToken(RichTextBoxForToken.Text);
                if (tokenResult != AccessTokenResult.NoToken())
                {
                    if (tokenResult.Status == AccessTokenStatus.Valid)
                    {
                        MessageBox.Show(@"The token is valid");
                    }
                    else
                    {
                        MessageBox.Show(@"The token is not valid");
                    }
                }
                else
                {
                    MessageBox.Show(@"Please paste the token first");
                }
            }
        }

        private void ButtonSaveTokenData_Click(object sender, EventArgs e)
        {
            // save token and all other text box data to a file as json format
            var token = RichTextBoxForToken.Text.Trim();
            var issuerToken = TextBoxIssuerToken.Text.Trim();
            var audience = TextBoxAudience.Text.Trim();
            var issuer = TextBoxIssuer.Text.Trim();

            var tokenData = new TokenData
            {
                Token = token,
                IssuerToken = issuerToken,
                Audience = audience,
                Issuer = issuer
            };

            var json = JsonConvert.SerializeObject(tokenData, Formatting.Indented);
            File.WriteAllText("tokenData.json", json);

            MessageBox.Show(@"Token data saved successfully");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // load the text box data from the file
            if (File.Exists("tokenData.json"))
            {
                var json = File.ReadAllText("tokenData.json");
                var tokenData = JsonConvert.DeserializeObject<TokenData>(json);

                RichTextBoxForToken.Text = tokenData?.Token;
                TextBoxIssuerToken.Text = tokenData?.IssuerToken;
                TextBoxAudience.Text = tokenData?.Audience;
                TextBoxIssuer.Text = tokenData?.Issuer;
            }
            else
            {
                RichTextBoxForToken.Focus();
            }
        }
    }

    public class TokenData
    {
        public string Token { get; set; }
        public string IssuerToken { get; set; }
        public string Audience { get; set; }
        public string Issuer { get; set; }
    }
}